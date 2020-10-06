using System;

namespace Listing_1_80_Creating_a_lambda_expression_with_multiple_statements
{
    class Program
    {
        public delegate int Calculate(int x, int y);
        static void Main()
        {
            Calculate calc = (x, y) =>
            {
                Console.WriteLine("Adding numbers");
                return x + y;
            };
            int result = calc(3, 4);
        }
    }
}
