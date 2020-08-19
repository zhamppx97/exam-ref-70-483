using System;
using System.Threading.Tasks;

namespace Listing_1_8_Starting_a_new_Task
{
    class Program
    {
        public static void Main()
        {
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write('*');
                }
            });
            t.Wait();
        }
    }
}
