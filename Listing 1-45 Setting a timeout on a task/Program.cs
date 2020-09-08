using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_45_Setting_a_timeout_on_a_task
{
    class Program
    {
        static void Main()
        {
            Task longRunning = Task.Run(() =>
            {
                Thread.Sleep(10000);
            });

            int i = Task.WaitAny(new[] { longRunning }, 1000);

            if (i == -1)
            {
                Console.WriteLine("Task timed out");
            }
        }
    }
}
