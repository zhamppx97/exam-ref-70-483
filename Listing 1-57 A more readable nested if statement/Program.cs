using System;

namespace Listing_1_57_A_more_readable_nested_if_statement
{
    class Program
    {
        static void Main()
        {
            bool x = true;
            bool y = true;

            if (x)
            {
                if (y)
                {
                    F();
                }
                else
                {
                    G();
                }
            }
        }

        static void F()
        {
            Console.WriteLine("F");
        }

        static void G()
        {
            Console.WriteLine("G");
        }
    }
}
