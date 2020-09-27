using System;

namespace Listing_1_56_Using_multiple_if_else_statements
{
    class Program
    {
        static void Main()
        {
            bool b = false;
            bool c = true;

            if (b)
            {
                Console.WriteLine("b is true");
            }
            else if (c)
            {
                Console.WriteLine("c is true");
            }
            else
            {
                Console.WriteLine("b and c are false");
            }
        }
    }
}
