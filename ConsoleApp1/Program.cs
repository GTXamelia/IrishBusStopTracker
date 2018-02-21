using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace IrishBusStopTracker
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] BusStopID = new string[] { "522691", "522961", "522811" };

            for (int i = 0; i < BusStopID.Length; i++)
            {

                using (WebClient wc = new WebClient())
                {
                    var obj = JsonConvert.DeserializeObject<RootObject>(wc.DownloadString("https://data.dublinked.ie/cgi-bin/rtpi/realtimebusinformation?stopid=" + BusStopID[i] + "&format=json"));

                    Console.WriteLine("--==BusStop==--" +
                                  "{0}", obj);
                }
            }

            Console.ReadLine();
        }
    }
}
