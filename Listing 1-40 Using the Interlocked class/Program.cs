using System;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_40_Using_the_Interlocked_class
{
    class Program
    {
        static void Main()
        {
            int n = 0;
            var up = Task.Run(() =>
            {
                for (int i = 0; i < 1000000; i++)
                {
                    Interlocked.Increment(ref n);
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                Interlocked.Decrement(ref n);
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
