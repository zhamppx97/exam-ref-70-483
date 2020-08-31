using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_41_Compare_and_exchange_as_a_nonatomic_operation
{
    class Program
    {
        static int value = 1;
        static void Main()
        {
            Task t1 = Task.Run(() =>
            {
                if (value == 1)
                {
                    Thread.Sleep(1000);
                    value = 2;
                }
            });

            Task t2 = Task.Run(() =>
             {
                 value = 3;
             });

            Task.WaitAll(t1, t2);
            Console.WriteLine(value);
        }
    }
}
