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

        public static void BusStopGeneratorMain()
        {
            // 522691 - gHotel Dublin Road (Galway)
            // 522961 - Opposite Londis Dublin Road (Galway)
            // 522811 - GMIT Dublin Road (Galway)
            /// To add more stops use "http://www.buseireann.ie/inner.php?id=403" and copy the ID of the bus stop
            string[] BusStopID = new string[] {"522691"};

            for (int i = 0; i < BusStopID.Length; i++)
            {

                using (WebClient wc = new WebClient())
                {
                    var obj = JsonConvert.DeserializeObject<RootObject>(wc.DownloadString("https://data.dublinked.ie/cgi-bin/rtpi/realtimebusinformation?stopid=" + BusStopID[i] + "&format=json"));

                    Console.WriteLine("--==Bus Stop({0})==--" +
                                  "{1}", BusStopID[i], obj);
                }
            }
        }
    }
}
