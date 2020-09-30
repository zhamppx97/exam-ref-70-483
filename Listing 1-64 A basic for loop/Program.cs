using System;

namespace Listing_1_64_A_basic_for_loop
{
    class Program
    {
        static void Main()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }
    }
}
