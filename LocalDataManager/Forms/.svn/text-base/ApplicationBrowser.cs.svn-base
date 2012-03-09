using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Disney.iDash.Shared;

namespace Disney.iDash.LocalDataManager
{
    public partial class ApplicationBrowser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private LocalDataEntities localDataContext = null;

        #region Public methods
        //-----------------------------------------------------------------------------------------
        public ApplicationBrowser()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void RefreshGrid()
        {
            try
            {
                if (localDataContext == null)
                {
                    localDataContext = new LocalDataEntities(Properties.Settings.Default.LocalConnectionString);
                    localDataContext.DetectChanges();
                }
                bindingSource.DataSource = localDataContext.EDMApplications;

                foreach (var fieldName in new string[] {"Id", "UserMenuOptions", "Users"})
                {
                    var col = viewItems.Columns.ColumnByFieldName(fieldName);
                    if (col != null)
                    {
                        col.Visible = false;
                        col.OptionsColumn.ShowInCustomizationForm = false;
                    }
                }
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //-----------------------------------------------------------------------------------------
        #endregion

        #region Private methods
        //-----------------------------------------------------------------------------------------
        private bool Save()
        {
            var saved = false;
            try
            {
                localDataContext.EDMApplications.Context.SaveChanges();
                RefreshGrid();
                saved = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return saved;
        }
        //-----------------------------------------------------------------------------------------
        #endregion

        #region Private event handlers
        //-----------------------------------------------------------------------------------------
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        
        private void viewItems_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void viewItems_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            btnDelete.Enabled = true;
        }

        private void viewItems_RowCountChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;
        }

        private void Browser_Shown(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void Browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            localDataContext.Dispose();
        }

        private void Browser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnSave.Enabled)
                switch (Question.YesNoCancel("Changes have been made and not saved.\r\n\r\nSave them?", this.Text))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        e.Cancel = !Save();
                        break;

                    case System.Windows.Forms.DialogResult.No:
                        break;

                    case System.Windows.Forms.DialogResult.Cancel:
                        e.Cancel=true;
                        break;
                }
        }
        //-----------------------------------------------------------------------------------------
        #endregion
    }
}