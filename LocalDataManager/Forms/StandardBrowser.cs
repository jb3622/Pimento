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
    public partial class StandardBrowser : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public StandardBrowser()
        {
            InitializeComponent();
        }

        public void ShowForm(BrowserController browserController)
        {
            browserControl1.BrowserController = browserController;
            this.Text = browserController.Caption;
            this.Show();
        }

        private void StandardBrowser_Shown(object sender, EventArgs e)
        {
            browserControl1.RefreshGrid();
            }

        private void StandardBrowser_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (browserControl1.IsDirty)
                switch (Question.YesNoCancel("Changes have been made and not saved.\r\n\r\nSave them?", this.Text))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        e.Cancel = !browserControl1.Save();
                        break;

                    case System.Windows.Forms.DialogResult.No:
                        break;

                    case System.Windows.Forms.DialogResult.Cancel:
                        e.Cancel=true;
                        break;
                }
        }
        }
}