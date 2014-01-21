using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using PSpaceStatusChanger;
using System.Windows.Forms;

namespace PSpaceStatusChanger
{
    public static class Requests
    {
        public static void SetStatus(bool IsOpen)
        {
            WebClient wc = new WebClient();

            string param="";
            if(IsOpen==true)
                param="open";
            else
                param="close";

            try
            {
                wc.DownloadString("http://www.p-space.gr/status/set.php?"+param);
            }
            catch (Exception)
            {
                MessageBox.Show("Error setting status");
            }
        }

        public static List<JSON_resp.Event> GetLastEvents(int history)
        {
            WebClient wc = new WebClient();
            try
            {
                var response = wc.DownloadString("http://pspace.dyndns.org:88/report/?limit=" + history + "&json");
                var data = Newtonsoft.Json.JsonConvert.DeserializeObject<JSON_resp.RootObject>(response);
                return data.events;
            }
            catch (Exception)
            {
                return null;
            }            
        }

        public static int CheckStatus()
        {
            WebClient wc = new WebClient();

            string str = "";
            try
            {
                str=wc.DownloadString("http://www.p-space.gr/status/");
            }
            catch (Exception)
            {
                str = "";
            }

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
