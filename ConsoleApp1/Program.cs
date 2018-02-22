using System;
using System.Threading;

namespace IrishBusStopTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread refresherThread = new Thread(new ThreadStart(TimerStart)); // New thread
            refresherThread.Start(); // Start thread
        }

        static void TimerStart()
        {
			// Endless while loop to keep generating information
            while (true)
            {
                PrintToScreen();
                Thread.Sleep(1000 * 10 * 1); //(Milliseconds) * (Seconds) * (Minutes)
			}
        }

        static void PrintToScreen()
        {
            Console.Clear(); // Clears console of out of date information
            BusStopGenerator.BusStopGeneratorMain(); // Gets JSON data to be output
        }
    }
}