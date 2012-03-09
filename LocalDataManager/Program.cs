using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using Disney.iDash.Shared;
using Disney.iDash.LocalData;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Deployment.Application;


namespace Disney.iDash.LocalDataManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Allow only one instance to run.
            var singleInstance = new SingleInstance();

            if (singleInstance.IsRunning)
            {
                singleInstance.Activate();
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                OfficeSkins.Register();
                DevExpress.Skins.SkinManager.EnableFormSkins();
                DevExpress.Skins.SkinManager.EnableMdiFormSkins();
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle("Money Twins");

                SetLocalDataLocation();
                var exit = false;
                if (ShowLogin())
                {
                    var mainForm = new MainForm();

                    if (System.Diagnostics.Debugger.IsAttached)
                    {
                        Application.Run(mainForm);
                    }
                    else
                    {
                        try
                        {
                            Application.Run(mainForm);
                        }
                        catch (Exception ex)
                        {
                            ErrorDialog.Show(ex, "Unhandled exception");
                        }
                    }
                }

                Environment.Exit(0);
            }
        }

        static bool ShowLogin()
        {
            var login = new Disney.iDash.LocalDataManager.LoginDialog();
            return login.ShowForm();
        }

        static bool SetLocalDataLocation()
        {
            var result = false;
            var remoteDataFilename = string.Empty;
            if (ApplicationDeployment.IsNetworkDeployed)
            {
                var path = ApplicationDeployment.CurrentDeployment.UpdateLocation.AbsoluteUri;
                remoteDataFilename = path.Substring(0, path.LastIndexOf('/') + 1) + Properties.Settings.Default.LocalDataFilename;
            }
            else
                remoteDataFilename = Properties.Settings.Default.LocalDataPath + Properties.Settings.Default.LocalDataFilename;

            result = Session.CopyRemoteConfigFile(remoteDataFilename) && Session.TestConnection(Session.GetLocalConfigFileName(), Properties.Settings.Default.LocalDataFileVersionRequired);

            return result;
        }

    }
}
