using System;

namespace Listing_1_59_Nesting_the_null_coalescing_operator
{
    class Program
    {
        static void Main()
        {
            int? x = null;
            int? z = null;
            int y = x ?? z ?? -1;
            Console.WriteLine(y);
        }
    }
}
