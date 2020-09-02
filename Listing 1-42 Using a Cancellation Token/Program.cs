using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_42_Using_a_Cancellation_Token
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
            }, token);

            Console.WriteLine("Press enter to stop the task");
            Console.ReadLine();
            cancellation.Cancel();

            Console.WriteLine("Press enter to end the application");
            Console.ReadLine();
        }
    }
}
