using System;
using System.Threading;

namespace Listing_1_2_Using_a_background_thread
{
    class Program
    {
        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
            }
        }

        public static void Main()
        {
            // If you run this application with the IsBackground property set to true,
            // the application exits immediately. If you set it to false (create a foreground),
            // the application prints the ThreadProc message ten times.
            Thread t = new Thread(new ThreadStart(ThreadMethod))
            {
                IsBackground = true
            };
            t.Start();
        }
    }
}
