using System;

namespace Listing_1_74_goto_statement_with_a_label
{
    class Program
    {
        static void Main()
        {
            int x = 3;
            if (x == 3) goto customLabel;
            x++;

            customLabel:
            Console.WriteLine(x);
        }
    }
}
