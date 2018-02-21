using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net;

namespace IrishBusStopTracker
{
    class BusStopGenerator
    {

        static void Main(string[] args)
        {
            // 522691 - gHotel Dublin Road (Galway)
            // 522961 - Opposite Londis Dublin Road (Galway)
            // 522811 - GMIT Dublin Road (Galway)
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
