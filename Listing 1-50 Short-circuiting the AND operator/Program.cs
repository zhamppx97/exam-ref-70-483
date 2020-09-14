using System;

namespace Listing_1_50_Short_circuiting_the_AND_operator
{
    class Program
    {
        static void Main()
        {
            Process("v Hello");
        }

        static void Process(string input)
        {
            bool result = (input != null) && (input.StartsWith("v"));
            Console.WriteLine(result);
        }
    }
}
