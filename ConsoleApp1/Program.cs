using System;
using System.Threading;

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
            BusStopGenerator.BusStopGeneratorMain();
        }
    }
}