using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_44_Adding_a_continuation_for_canceled_tasks
{
    class Program
    {
        static void Main()
        {
            CancellationTokenSource cancellation = new CancellationTokenSource();
            CancellationToken token = new CancellationToken();
            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.Write("*");
                    Thread.Sleep(1000);
                }

                throw new OperationCanceledException();
            }, token).ContinueWith((t) =>
            {
                t.Exception.Handle((e) => true);
                Console.WriteLine("You have canceled the task");
            }, TaskContinuationOptions.OnlyOnCanceled);
        }
    }
}
