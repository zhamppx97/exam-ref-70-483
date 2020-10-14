using System;

namespace Listing_1_92_Using_Environment_FailFast
{
    class Program
    {
        static void Main()
        {
            string s = Console.ReadLine();
            try
            {
                int i = int.Parse(s);
                if (i == 97) Environment.FailFast("Special number entered");
            }
            finally
            {
                Console.WriteLine("Program complete.");
            }
        }
    }
}
