using System;

namespace Listing_1_63_goto_in_a_switch_statement
{
    class Program
    {
        static void Main()
        {
            int i = 1;
            switch (i)
            {
                case 1:
                    Console.WriteLine("Case 1");
                    goto case 2;
                case 2:
                    Console.WriteLine("Case 2");
                    break;
                default:
                    break;
            }
        }
    }
}
