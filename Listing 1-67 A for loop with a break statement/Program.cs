using System;

namespace Listing_1_67_A_for_loop_with_a_break_statement
{
    class Program
    {
        static void Main()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == 4) break;
                Console.Write(values[i]);
            }
        }
    }
}
