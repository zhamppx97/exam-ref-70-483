using System;
using System.Runtime.ExceptionServices;

namespace Listing_1_97_Using_Exception_Dispatchinfo_Throw
{
    class Program
    {
        static void Main()
        {
            ExceptionDispatchInfo possibleException = null;

            try
            {
                string s = Console.ReadLine();
                int.Parse(s);
            }
            catch (FormatException e)
            {
                possibleException = ExceptionDispatchInfo.Capture(e);
            }

            if (possibleException != null)
            {
                possibleException.Throw();
            }
        }
    }
}
