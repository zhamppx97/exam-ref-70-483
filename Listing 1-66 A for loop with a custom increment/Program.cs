using System;

namespace Listing_1_66_A_for_loop_with_a_custom_increment
{
    class Program
    {
        static void Main()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < values.Length; i += 2)
            {
                Console.Write(values[i]);
            }
        }
    }
}
