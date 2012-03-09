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
    public partial class UserDetailsForm : DevExpress.XtraEditors.XtraForm
    {
        private bool _refeshParent = false;
        private eUser _user = null;
        private LocalDataEntities _context = new LocalDataEntities(Session.LocalDataConnection);
        private BrowserControl _browser = null;

        private bool _isDirty = false;

        private bool IsDirty
        {
            get { return _isDirty; }
            set
            {
                _isDirty = value;
                btnSave.Enabled = _isDirty;
            }
        }

        #region Public methods
        //-----------------------------------------------------------------------------------------
        public UserDetailsForm()
        {
            InitializeComponent();

            listMenuOptions.SelectedDisplayMember = "MenuOption";
            listMenuOptions.SelectedValueMember = "Id";
            listMenuOptions.AvailableDisplayMember = "MenuOption";
            listMenuOptions.AvailableValueMember = "Id";
            listMenuOptions.OnChanged += ((sender, e) =>
                {
                    IsDirty = true;
            });

            listMenuOptions.OnMoveItem += ((source, target, selectedItems, moveAll) =>
            {
                var moved = false;
                var sourceItems = (List<eMenuOption>)source.DataSource;
                var targetItems = (List<eMenuOption>)target.DataSource;

                if (moveAll)
                    {
                    foreach (eMenuOption item in sourceItems)
                        if (item.EntityState != EntityState.Deleted)
                            targetItems.Add(item);
                    sourceItems.Clear();
                    moved = true;
                    }
                else
                {
                    var temp = new List<eMenuOption>();

                    foreach (eMenuOption item in selectedItems)
                    {
                        temp.Add(item);
                        targetItems.Add(item);
                    }

                    foreach (eMenuOption item in temp)
                        sourceItems.Remove(item);

                    moved = true;
                }

                if (moved)
                    UpdateMenuOptions((int)cboApplications.EditValue);

                return moved;
                });

            listApplications.SelectedDisplayMember = "ApplicationName";
            listApplications.SelectedValueMember = "Id";
            listApplications.AvailableDisplayMember = "ApplicationName";
            listApplications.AvailableValueMember = "Id";

            listApplications.OnChanged += ((sender, e) =>
                {
                    IsDirty = true;
                });

            listApplications.OnMoveItem += ((source, target, selectedItems, moveAll) =>
            {
                var moved = false;
                var sourceItems = (List<eApplication>)source.DataSource;
                var targetItems = (List<eApplication>)target.DataSource;

                if (moveAll)
                {
                    foreach (eApplication item in sourceItems)
                        if (item.EntityState != EntityState.Deleted)
                            targetItems.Add(item);
                    sourceItems.Clear();
                    moved = true;
                }
                else
                {
                    var temp = new List<eApplication>();

                    foreach (eApplication item in selectedItems)
                    {
                        temp.Add(item);
                        targetItems.Add(item);
                    }

                    foreach (eApplication item in temp)
                        sourceItems.Remove(item);

                    moved = true;
                }

                return moved;
            });

            listEnvironments.AvailableDisplayMember = "EnvironmentName";
            listEnvironments.AvailableValueMember = "Id";
            listEnvironments.SelectedDisplayMember = "EnvironmentName";
            listEnvironments.SelectedValueMember = "Id";

            listEnvironments.OnMoveItem += ((source, target, selectedItems, moveAll) =>
            {
                var moved = false;
                var sourceItems = (List<eEnvironment>)source.DataSource;
                var targetItems = (List<eEnvironment>)target.DataSource;

                if (moveAll)
                {
                    foreach (eEnvironment item in sourceItems)
                        if (item.EntityState != EntityState.Deleted)
                            targetItems.Add(item);
                    sourceItems.Clear();
                    moved = true;
                }
                else
                {
                    var temp = new List<eEnvironment>();

                    foreach (eEnvironment item in selectedItems)
                    {
                        temp.Add(item);
                        targetItems.Add(item);
                    }

                    foreach (eEnvironment item in temp)
                        sourceItems.Remove(item);

                    moved = true;
                }

                return moved;
            });

            listEnvironments.OnChanged += ((sender, e) =>
            {
                IsDirty = true;
            });

        }

        public void ShowForm(BrowserControl browser, object row)
        {
            var qry = from u in _context.eUsers
                      where u.Id == ((eUser)row).Id
                      select u;

            if (row == null)
            {
                _user = new eUser();
                _user.Active = true;
                _user.NetworkId = string.Empty;
                _user.Lastname = string.Empty;
                _user.Firstname = string.Empty;
                _user.eMail = string.Empty;
                _user.Department = string.Empty;
                _user.Team = string.Empty;
            }
            else
                _user = qry.First();

            _user.PropertyChanged += ((sender, e) =>
            {
                IsDirty = true;
            });

            _browser = browser;
            this.Show();
        }
        //-----------------------------------------------------------------------------------------
        #endregion

        #region Private methods
        //-----------------------------------------------------------------------------------------
        private void RefreshApplicationCombo()
        {
            var qry = from a in _context.eApplications
                      orderby a.ApplicationName
                      select a;

            var data = qry.ToList();
            cboApplications.Properties.DataSource = data;

            if (data != null && data.Count() > 0)
                cboApplications.EditValue = data[0].Id;
        }

        private void RefreshApplicationList()
        {
            var qryAvailable = from a in _context.eApplications.AsEnumerable().Except(_user.vApplications)
                               orderby a.ApplicationName
                               select a;

            var qrySelected = from a in _user.vApplications
                              orderby a.ApplicationName
                              select a;

            listApplications.AvailableDataSource = qryAvailable.ToList();
            listApplications.SelectedDataSource = qrySelected.ToList();
        }

        private void RefreshEnvironmentList()
        {
            var qryAvailable = from e in _context.eEnvironments.AsEnumerable().Except(_user.vEnvironments)
                               orderby e.EnvironmentName
                               select e;

            var qrySelected = from e in _user.vEnvironments
                              orderby e.EnvironmentName
                              select e;

            listEnvironments.AvailableDataSource = qryAvailable.ToList();
            listEnvironments.SelectedDataSource = qrySelected.ToList(); 
        }

        private void RefreshMenuOptions()
        {
            var applicationId = (int) (cboApplications.EditValue ?? -1m);
            var qryAvailable = from o in _context.eMenuOptions.AsEnumerable().Except(_user.vMenuOptions)
                               where o.ApplicationId == applicationId
                               && o.IsRestricted == true
                               orderby o.MenuOption
                               select o;

            var qrySelected = from o in _user.vMenuOptions
                              where o.ApplicationId == applicationId
                              orderby o.Tab, o.MenuOption
                              select o;

            listMenuOptions.AvailableDataSource = qryAvailable.ToList();
            listMenuOptions.SelectedDataSource = qrySelected.ToList();
            }

        private void UpdateApplications()
        {
            _user.vApplications.Clear();
            foreach (var item in (List<eApplication>)listApplications.SelectedDataSource)
                _user.vApplications.Add(item);            
        }

        private void UpdateEnvironments()
        {
            _user.vEnvironments.Clear();
            foreach (var item in (List<eEnvironment>)listEnvironments.SelectedDataSource)
                _user.vEnvironments.Add(item);
        }

        private void UpdateMenuOptions(int applicationId)
        {
            if (listMenuOptions.SelectedDataSource != null)
            {
                var currentSelection = (List<eMenuOption>)listMenuOptions.SelectedDataSource;

                foreach (var item in currentSelection)
                    if (!_user.vMenuOptions.Contains(item))
                        _user.vMenuOptions.Add(item);

                var index = 0;
                while (index < _user.vMenuOptions.Where((o)=>(o.ApplicationId == applicationId)).Count())
                {
                    var item = _user.vMenuOptions.Where((o) => (o.ApplicationId == applicationId)).ToArray()[index];
                    if (!currentSelection.Contains(item))
                        _user.vMenuOptions.Remove(item);
                    else
                        index++;
                }
            }
        }

        private bool Save()
        {
            var saved = true;

            try
            {
                UpdateApplications();
                UpdateEnvironments();

                if (_user.EntityState == EntityState.Detached)
                    _context.eUsers.AddObject(_user);
                _context.SaveChanges();
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

                saved = false;
            }
            return saved;

        }
        //-----------------------------------------------------------------------------------------
        #endregion

        #region Private event handlers
        //-----------------------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Save())
                this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboApplications_EditValueChanged(object sender, EventArgs e)
        {
            RefreshMenuOptions();
        }

        private void UserDetailsForm_Shown(object sender, EventArgs e)
        {
            txtNetworkId.DataBindings.Add("Text", _user, "NetworkId");
            txtFirstname.DataBindings.Add("Text", _user, "Firstname");
            txtLastname.DataBindings.Add("Text", _user, "Lastname");
            txtEmail.DataBindings.Add("Text", _user, "eMail");
            chkActive.DataBindings.Add("Checked", _user, "Active", true, DataSourceUpdateMode.OnPropertyChanged);
            txtDepartment.DataBindings.Add("Text", _user, "Department");
            txtTeam.DataBindings.Add("Text", _user, "Team");

            RefreshApplicationList();
            RefreshEnvironmentList();
            RefreshApplicationCombo();

            txtNetworkId.Focus();
            IsDirty = false;
        }
       
        private void UserDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_user.EntityState != EntityState.Unchanged)
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
        //-----------------------------------------------------------------------------------------
        #endregion
    }
}