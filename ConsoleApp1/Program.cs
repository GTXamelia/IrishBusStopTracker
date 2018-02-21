using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace IrishBusStopTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread refresherThread = new Thread(new ThreadStart(TimerStart));
            refresherThread.Start();
        }

        static void TimerStart()
        {
            while (true)
            {
                PrintToScreen();
                Thread.Sleep(1000 * 10 * 1); // Sleep for 10 Seconds
            }
        }

        static void PrintToScreen()
        {
            Console.Clear();
            Console.WriteLine(DateTime.Now.ToString());
            BusStopGenerator.BusStopGeneratorMain();
        }
    }
}
