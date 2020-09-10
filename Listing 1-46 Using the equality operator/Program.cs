using System;

namespace Listing_1_46_Using_the_equality_operator
{
    class Program
    {
        static void Main()
        {
            int x = 97;
            int y = 0;
            int z = 97;

            Console.WriteLine(x == y); // False
            Console.WriteLine(x == z); // True
        }
    }
}
