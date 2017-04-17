using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

using Shadowsocks.Controller;
using Shadowsocks.Util;
using Shadowsocks.View;

namespace Shadowsocks
{
    static class Program
    {
        public static ShadowsocksController Controller { get; private set; }
        public static MenuViewController MenuController { get; private set; }

        private static LoginForm loginForm { get; set; }
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Utils.ReleaseMemory(true);
            using (Mutex mutex = new Mutex(false, "Global\\Shadowsocks_" + Application.StartupPath.GetHashCode()))
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                if (!mutex.WaitOne(0, false))
                {
                    Process[] oldProcesses = Process.GetProcessesByName("Shadowsocks");
                    if (oldProcesses.Length > 0)
                    {
                        Process oldProcess = oldProcesses[0];
                    }
                    MessageBox.Show(I18N.GetString("Find Shadowsocks icon in your notify tray.") + "\n" +
                        I18N.GetString("If you want to start multiple Shadowsocks, make a copy in another directory."),
                        I18N.GetString("Shadowsocks is already running."));
                    return;
                }
                Directory.SetCurrentDirectory(Application.StartupPath);
#if DEBUG
                Logging.OpenLogFile();

                // truncate privoxy log file while debugging
                string privoxyLogFilename = Utils.GetTempPath("privoxy.log");
                if (File.Exists(privoxyLogFilename))
                    using (new FileStream(privoxyLogFilename, FileMode.Truncate)) { }
#else
                Logging.OpenLogFile();
#endif
                Controller = new ShadowsocksController();
                if (Controller.NeedToLogin)
                {
                    loginForm = new LoginForm(Controller);
                    loginForm.Show();
                    loginForm.FormClosed += LoginForm_FormClosed;
                }
                SystemRun(!Controller.NeedToLogin);
            }
        }

        public static void SystemRun(bool runMenu)
        {
            if (runMenu)
            {
                MenuController = new MenuViewController(Controller);
            }
            Controller.Start();
            Application.Run();
        }

        private static void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (loginForm.IsLoginAction)
            {
                MenuController = new MenuViewController(Controller);
                ConfigForm configForm = new ConfigForm(Controller);
                configForm.Show();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}
