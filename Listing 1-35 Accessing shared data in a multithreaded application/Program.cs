using System;
using System.Threading.Tasks;

namespace Listing_1_35_Accessing_shared_data_in_a_multithreaded_application
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
                    n++;
                }
            });

            for (int i = 0; i < 1000000; i++)
            {
                n--;
            }

            up.Wait();
            Console.WriteLine(n);
        }
    }
}
