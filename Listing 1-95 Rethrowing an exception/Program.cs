using System;

namespace Listing_1_95_Rethrowing_an_exception
{
    class Program
    {
        static void Main()
        {
            try
            {
                int x = int.Parse("s");
            }
            catch (Exception logEx)
            {
                Log(logEx);
                throw;
            }
        }

        static void Log(Exception logEx)
        {
            Console.WriteLine(logEx);
        }
    }
}
