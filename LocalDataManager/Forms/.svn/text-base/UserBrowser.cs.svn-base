using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Disney.iDash.LocalDataManager
{
    public partial class UserBrowser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private LocalDataEntities localDataContext = null;

        public UserBrowser()
        {
            InitializeComponent();
        }

        public void ShowForm()
        {
            RefreshGrid();
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
                bindingSource.DataSource = localDataContext.EDMUsers;
                btnSave.Enabled = false;
                btnDelete.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                localDataContext.EDMUsers.Context.SaveChanges();
                RefreshGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Browser_FormClosed(object sender, FormClosedEventArgs e)
        {
            localDataContext.Dispose();
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

    }
}