using System;
using System.Threading.Tasks;

namespace Listing_1_36_Using_the_lock_keyword
{
    class Program
    {
        static void Main()
        {
            int n = 0;
            object _lock = new object();
            var up = Task.Run(() =>
             {
                 for (int i = 0; i < 1000000; i++)
                 {
                     lock (_lock)
                         n++;
                 }
             });

            for (int i = 0; i < 1000000; i++)
            {
                lock (_lock)
                    n--;
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
