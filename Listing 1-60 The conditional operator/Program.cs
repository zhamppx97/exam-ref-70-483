using System;

namespace Listing_1_60_The_conditional_operator
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(GetValue(true));
        }

        static int GetValue(bool p)
        {
            if (p)
            {
                return 1;
            }
            else
            {
                return 0;
            }

            return p ? 1 : 0;
        }
    }
}
