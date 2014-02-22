using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Win32;

namespace PSpaceStatusChanger
{
    public static class Program
    {
        static TrayIcon pi;
        static Timer tim;
        static int oldstatus = -5;
        static int olddate = 0;
        static int silent = 0;

        static void Main()
        {
            //EnableAutoStartup();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //check if another process already running
            if (System.Diagnostics.Process.GetProcessesByName(System.IO.Path.GetFileNameWithoutExtension(System.Reflection.Assembly.GetEntryAssembly().Location)).Count() > 1)
            {
                MessageBox.Show("Another instance is already running!");
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }

            silent = Properties.Settings.Default.silent_mode;
            pi = new TrayIcon();
            pi.Display();
            // Make sure the application runs!

            tim = new Timer();
            tim.Tick += new EventHandler(tim_Tick);
            UpdateTime();
            tim.Start();

            Application.Run();
        }

        static void tim_Tick(object sender, EventArgs e)
        {
            var newstatus = Requests.CheckStatus();
            if (newstatus != oldstatus)
            {
                if (newstatus == 1)
                {
                    pi.ShowMessage("P-Space Status Changed", "P-Space is now open!");
                    pi.SetOpen();
                }
                else
                {
                    pi.ShowMessage("P-Space Status Changed","P-Space is now closed!");
                    pi.SetClosed();
                }
                oldstatus = newstatus;
            }

            if (silent!=1)
            {
                var lastevents = Requests.GetLastEvents(1);
                if (lastevents != null && lastevents[0].t != olddate)
                {
                    if (olddate != 0)
                    {
                        pi.ShowMessage("P-Space Door Event", lastevents[0].extra);
                    }
                    olddate = lastevents[0].t;
                } 
            }
        }

        public static void UpdateTime()
        {
            tim.Interval = Properties.Settings.Default.refresh_interval * 1000;
        }

        public static void UpdateSilent()
        {
            silent = Properties.Settings.Default.silent_mode;
        }

        public static void EnableAutoStartup()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (!IsStartupItem())
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("PSpaceNotifier", Application.ExecutablePath.ToString());
        }

        public static void DisableAutoStartup()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (IsStartupItem())
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("PSpaceNotifier", false);
        }

        public static bool IsStartupItem()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if ((rkApp.GetValue("PSpaceNotifier") == null) || (rkApp.GetValue("PSpaceNotifier").ToString() != Application.ExecutablePath.ToString()))
                // The value doesn't exist, the application is not set to run at startup
                return false;
            else
                // The value exists, the application is set to run at startup
                return true;
        }
    }
}
