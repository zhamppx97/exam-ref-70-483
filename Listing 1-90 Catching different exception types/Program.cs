using System;

namespace Listing_1_90_Catching_different_exception_types
{
    class Program
    {
        static void Main()
        {
            try
            {
                int i = int.Parse("s");
            }
            catch (ArgumentNullException)
            {
                Console.WriteLine("You need to enter a value");
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} is not a valid number. Please try again", "s");
            }
        }
    }
}
