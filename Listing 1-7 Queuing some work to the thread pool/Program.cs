using System;
using System.Threading;

namespace Listing_1_7_Queuing_some_work_to_the_thread_pool
{
    class Program
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working on a thread from threadpool");
            });
            Console.ReadLine();
        }
    }
}
