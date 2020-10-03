using System;

namespace Listing_1_71_foreach_loop
{
    class Program
    {
        static void Main()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
