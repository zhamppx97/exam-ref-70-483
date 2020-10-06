using System;

namespace Listing_1_79_Lambda_expression_to_create_a_delegate
{
    class Program
    {
        public delegate int Calculate(int x, int y);
        static void Main()
        {
            Calculate calc = (x, y) => x + y;
            Console.WriteLine(calc(3, 4));
            calc = (x, y) => x * y;
            Console.WriteLine(calc(3, 4));
        }
    }
}
