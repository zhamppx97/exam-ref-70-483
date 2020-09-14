using System;

namespace Listing_1_51_Using_the_XOR_operator
{
    class Program
    {
        static void Main()
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a ^ a);
            Console.WriteLine(a ^ b);
            Console.WriteLine(b ^ b);
        }
    }
}
