using System;

namespace Listing_1_65_A_for_loop_with_multiple_loop_variables
{
    class Program
    {
        static void Main()
        {
            int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int x = 0, y = values.Length - 1;
                ((x < values.Length) && (y >= 0));
                x++, y--)
            {
                Console.WriteLine(values[x]);
                Console.WriteLine(values[y]);
            }
        }
    }
}
