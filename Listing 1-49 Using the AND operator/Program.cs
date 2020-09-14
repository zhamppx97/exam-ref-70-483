using System;

namespace Listing_1_49_Using_the_AND_operator
{
    class Program
    {
        static void Main()
        {
            int value = 97;
            bool result = (0 < value) && (value < 100);
            Console.WriteLine(result);
        }
    }
}
