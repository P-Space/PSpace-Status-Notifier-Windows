using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PSpaceStatusChanger
{
    public class JSON_resp
    {
        public class Event
        {
            public string type { get; set; }
            public string extra { get; set; }
            public string name { get; set; }
            public int t { get; set; }
        }

        public class RootObject
        {
            public List<Event> events { get; set; }
        }
    }
}
