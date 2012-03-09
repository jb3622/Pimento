using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using Disney.iDash.Shared;
using System.Deployment.Application;
using System.Reflection;
using Disney.iDash.LocalData;

namespace Disney.iDash.LocalDataManager
{
    public partial class MainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {      

        public MainForm()
        {
            InitializeComponent();
        }

        void MainForm_Load(object sender, EventArgs e)
        {
            if (ApplicationDeployment.IsNetworkDeployed)
                this.barVersion.Caption = "v" + ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString(4);
            else
                this.barVersion.Caption = "v" + Assembly.GetEntryAssembly().GetName().Version.ToString();
            SelectLocalDataFile();
        }

        private void barOpen_ItemClick(object sender, ItemClickEventArgs e)
        {
            SelectLocalDataFile();
        }

        private void barExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }

        private void barApplications_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowBrowser(new ApplicationBrowserInfo());
        }

        private void barEnvironments_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowBrowser(new EnvironmentBrowserInfo());
        }

        private void barUsers_ItemClick(object sender, ItemClickEventArgs e)
        {
            ShowBrowser(new UserBrowserInfo());
        }

        private void ShowBrowser(BrowserController browserInfo)
        {
            var frm = (StandardBrowser)FormUtils.FindForm(browserInfo.Caption);
            if (frm == null)
            {
                frm = new StandardBrowser();
                frm.MdiParent = this;
                frm.ShowForm(browserInfo);
            }
            else
                frm.Activate();
        }

        private void SelectLocalDataFile()
        {
            if (openFileDialogLocalData.ShowDialog() == DialogResult.OK)
            {
                FormUtils.CloseAllForms(this);

                var connectionStrings = System.Configuration.ConfigurationManager.ConnectionStrings;
                var connection = connectionStrings["LocalDataEntities"];
                if (connection == null)
                    MessageBox.Show("LocalDataEntities entry is missing from app.config connectionStrings section", "app.config", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (Session.TestConnection( openFileDialogLocalData.FileName, 2))
                {
                    Session.LocalDataConnection = openFileDialogLocalData.FileName;
                
                barDatabase.Caption = openFileDialogLocalData.FileName;
                barApplications.Enabled = true;
                barEnvironments.Enabled = true;
                barUsers.Enabled = true;
            }
                else if (Session.LastException != null)
                {
                    MessageBox.Show(Session.LastException.Message, "Connection Failed");
                }
            }
            else
            {
                barApplications.Enabled = false;
                barEnvironments.Enabled = false;
                barUsers.Enabled = false;
            }
        }

        private void barClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            barDatabase.Caption = "No file open.";
            barApplications.Enabled = false;
            barEnvironments.Enabled = false;
            barUsers.Enabled = false;
        }
    }
}