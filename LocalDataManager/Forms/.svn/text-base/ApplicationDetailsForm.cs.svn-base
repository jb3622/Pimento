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
using System.ComponentModel;

namespace Disney.iDash.LocalDataManager.Forms
{
    public partial class ApplicationDetailsForm : DevExpress.XtraEditors.XtraForm
    {
        private bool _refeshParent = false;
        private eApplication _application = null;
        private LocalDataEntities _context = new LocalDataEntities(Session.LocalDataConnection);
        private BrowserControl _browser = null;
        private BrowserController _menuOptions = new MenuOptionBrowserInfo();

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
        public ApplicationDetailsForm()
        {
            InitializeComponent();
            listMenuOptions.OnChanged += ((sender, e) =>
            {
                IsDirty = true;
            });
            listMenuOptions.BrowserController = _menuOptions;

            _context.SavingChanges += ((sender, e) =>
                {
                    var item = e;
                });

            _context.ObjectMaterialized += ((sender, e) =>
                {
                    var item = e.Entity;
                });
        }

        void _context_ObjectMaterialized(object sender, ObjectMaterializedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ShowForm(BrowserControl browser, object row)
        {
            var qry = from a in _context.eApplications
                      where a.Id == ((eApplication)row).Id
                      select a;

            if (row == null)
            {
                _application = new eApplication();
                _application.Active = true;
                _application.ApplicationName = string.Empty;
            }
            else
                _application = qry.First();

            _application.PropertyChanged += ((sender, e) =>
            {
                IsDirty = true;
            });

            _browser = browser;
            this.Show();
            IsDirty = false;
        }
        //-----------------------------------------------------------------------------------------
        #endregion

        #region Private methods
        //-----------------------------------------------------------------------------------------
        private void RefreshMenuOptionsList()
        {
            var qry = from e in _application.vMenuOptions
                      orderby e.Tab, e.MenuOption
                      select e;

            listMenuOptions.Context = _context;
            listMenuOptions.RefreshGrid(qry.ToList());
        }

        private bool Save()
        {
            var saved = true;

            //try
            //{

            // add the new application entry to the list of applications
            if (_application.EntityState == EntityState.Detached)
                _context.eApplications.AddObject(_application);

            // link any new options to the application
            var editedList = (List<eMenuOption>)listMenuOptions.DataSource;
            foreach (var option in editedList)
            {
                if (option.vApplication == null)
                    option.vApplication = _application;
            }

            // remove any application options that have been deleted from the grid.
            var index = 0;
            while (index < _application.vMenuOptions.Count)
            {
                eMenuOption option = _application.vMenuOptions.ToArray()[index];
                if (!editedList.Exists((o) => (o.Id == option.Id)))
                {
                    option.vUsers.Clear();
                    _context.DeleteObject(option);
                }
                else
                    index++;
            }           
                        
            _context.DetectChanges();
            _context.SaveChanges(SaveOptions.AcceptAllChangesAfterSave);
            _refeshParent = true;
            IsDirty = false;
            //}
            //catch (Exception ex)
            //{
            //    string message = string.Empty;
            //    if (ex.InnerException == null)
            //        message = ex.Message;
            //    else
            //        message = ex.InnerException.Message;

            //    if (message.Contains("Entities") && message.Contains("modified") && message.Contains("deleted") && message.Contains("loaded"))
            //        message = "Changes have been made to this item, by other users or processes, while you were editing it.";

            //    MessageBox.Show(message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);

            //    saved = false;
            //}
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

        private void ApplicationDetailsForm_Shown(object sender, EventArgs e)
        {
            txtApplicationName.DataBindings.Add("Text", _application, "ApplicationName");
            chkActive.DataBindings.Add("Checked", _application, "Active", true, DataSourceUpdateMode.OnPropertyChanged);

            RefreshMenuOptionsList();

            txtApplicationName.Focus();
            IsDirty = false;
        }
       
        private void ApplicationDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_application.EntityState != EntityState.Unchanged && IsDirty)
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

        private void ApplicationDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _context.Dispose();
            if (_refeshParent)
                _browser.RefreshGrid();
        }
        //-----------------------------------------------------------------------------------------
        #endregion
    }
}