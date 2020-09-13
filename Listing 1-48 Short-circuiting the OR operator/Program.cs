using System;

namespace Listing_1_48_Short_circuiting_the_OR_operator
{
    class Program
    {
        public static void Main()
        {
            OrShortCircuit();
        }

        public static void OrShortCircuit()
        {
            bool x = true;
            bool result = x || GetY();
        }

        private static bool GetY()
        {
            Console.WriteLine("This method doesn't get called");
            return true;
        }
    }
}
