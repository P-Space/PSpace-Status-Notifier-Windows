using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace PSpaceStatusChanger
{
    public static class Requests
    {
        public static void SetStatus(bool IsOpen)
        {
            WebClient wc = new WebClient();
            if(IsOpen==true)
            {
                wc.DownloadString("http://www.p-space.gr/status/set.php?open");
            }
            else
            {
                wc.DownloadString("http://www.p-space.gr/status/set.php?close");
            }
        }

        public static int CheckStatus()
        {
            WebClient wc = new WebClient();
            string str = wc.DownloadString("http://www.p-space.gr/status/");
            int status = -1;
            if (Int32.TryParse(str, out status))
            {
                return status;
            }
            else
                return -1;
        }
    }
}
