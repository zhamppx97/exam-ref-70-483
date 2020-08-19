using System;
using System.Threading.Tasks;

namespace Listing_1_11_Scheduling_different_continuation_tasks
{
    class Program
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 97;
            });
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
        }
    }
}
