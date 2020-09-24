using System;

namespace Listing_1_54_Code_blocks_and_scoping
{
    class Program
    {
        static void Main()
        {
            bool b = true;
            if (b)
            {
                int r = 97;
                b = false;
            }
        }
    }
}
