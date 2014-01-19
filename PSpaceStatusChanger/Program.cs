using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PSpaceStatusChanger
{
    public static class Program
    {
        static TrayIcon pi;
        static Timer tim;
        static int oldstatus = -5;
        static void Main()
        {
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
    }
}
