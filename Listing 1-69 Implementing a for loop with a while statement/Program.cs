using System;

namespace Listing_1_69_Implementing_a_for_loop_with_a_while_statement
{
    class Program
    {
        static readonly int[] values = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        static void Main()
        {
            int index = 0;
            while (index < values.Length)
            {
                Console.WriteLine(values[index]);
                index++;
            }
        }
    }
}
