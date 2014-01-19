﻿using System;
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
        static void Main()
        {
            EnableAutoStartup();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            pi = new TrayIcon();
            pi.Display();
            // Make sure the application runs!

            tim = new Timer();
            tim.Tick += new EventHandler(tim_Tick);
            tim.Interval = 1000;
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
                    pi.ShowMessage("P-Space is now open!");
                    pi.SetOpen();
                }
                else
                {
                    pi.ShowMessage("P-Space is now closed!");
                    pi.SetClosed();
                }
                oldstatus = newstatus;
            }
        }

        static void EnableAutoStartup()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (!IsStartupItem())
                // Add the value in the registry so that the application runs at startup
                rkApp.SetValue("PSpaceNotifier", Application.ExecutablePath.ToString());
        }

        static void DisableAutoStartup()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (IsStartupItem())
                // Remove the value from the registry so that the application doesn't start
                rkApp.DeleteValue("PSpaceNotifier", false);
        }

        private static bool IsStartupItem()
        {
            // The path to the key where Windows looks for startup applications
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (rkApp.GetValue("PSpaceNotifier") == null)
                // The value doesn't exist, the application is not set to run at startup
                return false;
            else
                // The value exists, the application is set to run at startup
                return true;
        }
    }
}
