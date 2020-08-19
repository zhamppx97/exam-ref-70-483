using System;
using System.Threading.Tasks;

namespace Listing_1_9_Using_a_Task_that_returns_a_value
{
    class Program
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 97;
            });
            Console.WriteLine(t.Result);
        }
    }
}
