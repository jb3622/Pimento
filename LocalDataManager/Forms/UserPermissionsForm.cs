using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Windows.Forms;
using Disney.iDash.Shared;
using Disney.iDash.LocalData;
using Disney.iDash.LocalDataManager.Controls;

namespace Disney.iDash.LocalDataManager.Forms
{
    public partial class UserPermissionsForm : DevExpress.XtraEditors.XtraForm
    {
        private bool _refeshParent = false;
        private LocalDataEntities _context = new LocalDataEntities(Session.LocalDataConnection);
        private BrowserControl _browser = null;
        private List<object> _selectedUsers = null;

        private bool _isDirty = false;

        private bool IsDirty
        {
            get { return _isDirty; }
            set
            {
                _isDirty = value;
                btnApply.Enabled = _isDirty;
            }
        }

        #region Public methods
        //-----------------------------------------------------------------------------------------
        public UserPermissionsForm()
        {
            InitializeComponent();
        }

        public void ShowForm(BrowserControl browser, List<object> selection)
        {
            _selectedUsers = selection;
            _browser = browser;
            this.Text = "User permissions: " + selection.Count + " user(s) selected";
            this.ShowDialog();
        }
        //-----------------------------------------------------------------------------------------
        #endregion

        #region Private methods
        //-----------------------------------------------------------------------------------------
        private void RefreshUserList()
        {
            lstAffectedUsers.Items.Clear();
            foreach (var oUser in _selectedUsers)
            {
                var user = (eUser)oUser;
                lstAffectedUsers.Items.Add(user.Fullname);
            }
        }
        
        private void RefreshApplicationList()
        {
            var qry = from a in _context.eApplications
                      orderby a.ApplicationName
                      select a;
            lstApplications.DisplayMember = "ApplicationName";
            lstApplications.ValueMember = "Id";
            lstApplications.DataSource = qry.ToList();
        }

        private void RefreshEnvironmentList()
        {
            var qry = from e in _context.eEnvironments
                      orderby e.EnvironmentName
                      select e;

            lstEnvironments.DisplayMember = "EnvironmentName";
            lstEnvironments.ValueMember = "Id";
            lstEnvironments.DataSource = qry.ToList();
        }

        private void RefreshMenuOptionsList()
        {
            var qry = from o in _context.eMenuOptions
                      where o.IsRestricted == true
                      orderby o.vApplication.ApplicationName, o.Tab, o.MenuOption
                      select new RestrictedMenuOption { Id = o.Id, MenuOption = o };

            lstMenuOptions.DisplayMember = "Description";
            lstMenuOptions.ValueMember = "Id";
            lstMenuOptions.DataSource = qry.ToList();

            foreach (var item in qry.ToList())
                Console.WriteLine("{0} - {1}", item.Id, item.Description);
        }

        private bool Save()
        {
            var saved = false;

            if (Question.YesNo("Saving the changes will replace all the existing options for the selected users.  Are you sure you want to proceed?", "Confirm"))
                try
                {
                    progressBarControl1.Visible = true;
                    progressBarControl1.Position = 0;
                    progressBarControl1.Properties.Maximum = _selectedUsers.Count();

                    foreach (var oUser in _selectedUsers)
                    {
                        progressBarControl1.Position++;
                        Application.DoEvents();

                        var qry = from u in _context.eUsers
                                  where u.Id == ((eUser)oUser).Id
                                  select u;

                        var user = qry.FirstOrDefault();

                        if (chkApplyActive.Checked)
                            user.Active = chkActive.Checked;

                        if (chkApplyDepartment.Checked)
                            user.Department = txtDepartment.Text;

                        if (chkApplyTeam.Checked)
                            user.Team = txtTeam.Text;

                        if (chkApplyApplications.Checked)
                        {
                            user.vApplications.Clear();
                            foreach (var item in lstApplications.CheckedItems)
                                user.vApplications.Add((eApplication)item);
                        }

                        if (chkApplyEnvironments.Checked)
                        {
                            user.vEnvironments.Clear();
                            foreach (var item in lstEnvironments.CheckedItems)
                                user.vEnvironments.Add((eEnvironment)item);
                        }

                        if (chkApplyMenuOptions.Checked)
                        {
                            user.vMenuOptions.Clear();
                            foreach (var item in lstMenuOptions.CheckedItems)
                                user.vMenuOptions.Add((eMenuOption)((RestrictedMenuOption)item).MenuOption);
                        }

                    }
                    progressBarControl1.Visible = false;
                    _context.DetectChanges();                   
                    _context.SaveChanges(SaveOptions.AcceptAllChangesAfterSave);

                    saved = true;
                    IsDirty = false;
                    _refeshParent = true;
                }
                catch (Exception ex)
                {
                    string message = string.Empty;
                    if (ex.InnerException == null)
                        message = ex.Message;
                    else
                        message = ex.InnerException.Message;

                    if (message.Contains("Entities") && message.Contains("modified") && message.Contains("deleted") && message.Contains("loaded"))
                        message = "Changes have been made to this item, by other users or processes, while you were editing it.";

                    MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            return saved;

        }

        private void RefreshButtons()
        {
            IsDirty = chkApplyActive.Checked
                || chkApplyDepartment.Checked
                || chkApplyTeam.Checked
                || chkApplyApplications.Checked
                || chkApplyEnvironments.Checked
                || chkApplyMenuOptions.Checked;
        }
        //-----------------------------------------------------------------------------------------
        #endregion

        #region Private event handlers
        //-----------------------------------------------------------------------------------------
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (Save())
                this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserDetailsForm_Shown(object sender, EventArgs e)
        {
            RefreshApplicationList();
            RefreshEnvironmentList();
            RefreshMenuOptionsList();
            RefreshUserList();
            IsDirty = false;
        }
       
        private void UserDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (IsDirty)
                switch (Question.YesNoCancel("Changes have been made and not saved.\r\n\r\nSave them?", this.Text))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        e.Cancel = !Save();
                        break;

                    case System.Windows.Forms.DialogResult.No:
                        break;

                    case System.Windows.Forms.DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }
        }

        private void UserDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
            if (_refeshParent)
                _browser.RefreshGrid();
        }

        private void chkApplyApplications_CheckStateChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }

        private void chkApplyEnvironments_CheckStateChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }

        private void chkApplyMenuOptions_CheckStateChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }

        private void chkApplyDepartment_CheckedChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }

        private void chkApplyActive_CheckedChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }

        private void chkApplyTeam_CheckedChanged(object sender, EventArgs e)
        {
            RefreshButtons();
        }
        //-----------------------------------------------------------------------------------------
        #endregion
    }

    public class RestrictedMenuOption
    {
        public int Id { get; set; }
        public eMenuOption MenuOption { get; set; }

        public string Description
        {
            get
            {
                if (MenuOption == null)
                    return "Nothing";
                else
                    return MenuOption.vApplication.ApplicationName + " - " + MenuOption.Tab + " - " + MenuOption.MenuOption;           
            }
        }

    }
}