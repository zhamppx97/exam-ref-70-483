using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_43_Throwing_Operation_Canceled_Exception
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
                token.ThrowIfCancellationRequested();
            }, token);

            try
            {
                Console.WriteLine("Press enter to stop the task");
                Console.ReadLine();
                cancellation.Cancel();
                task.Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.InnerExceptions[0].Message);
            }
            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
        }
    }
}
