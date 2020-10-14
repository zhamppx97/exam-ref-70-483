using System;

namespace Listing_1_88_Parsing_an_invalid_number
{
    class Program
    {
        static void Main()
        {
            string s = "NaN";
            int i = int.Parse(s);

            // Error
            // Input string was not in a correct format.
        }
    }
}
