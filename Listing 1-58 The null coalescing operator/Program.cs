using System;

namespace Listing_1_58_The_null_coalescing_operator
{
    class Program
    {
        static void Main()
        {
            int? x = null;
            int y = x ?? -1;
            Console.WriteLine(y);
        }
    }
}
