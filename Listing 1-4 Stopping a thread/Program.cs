using System;
using System.Threading;

namespace Listing_1_4_Stopping_a_thread
{
    class Program
    {
        public static void Main()
        {
            // In this case, the thread is initialized with a lambda expression
            // (which in turn is just a short-hand version of a delegate).
            // The thread keeps running until the thread finishes execution.
            bool stopped = false;
            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Running...");
                    Thread.Sleep(1000);
                }
            }));

            t.Start();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
