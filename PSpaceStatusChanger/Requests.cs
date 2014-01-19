using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using PSpaceStatusChanger;

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

        public static List<JSON_resp.Event> GetLastEvents(int history)
        {
            WebClient wc = new WebClient();
            var response = wc.DownloadString("http://pspace.dyndns.org:88/report/?limit="+history+"&json");
            var data = Newtonsoft.Json.JsonConvert.DeserializeObject<JSON_resp.RootObject>(response);
            return data.events;            
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
