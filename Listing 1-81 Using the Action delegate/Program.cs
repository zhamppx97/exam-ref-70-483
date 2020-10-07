using System;

namespace Listing_1_81_Using_the_Action_delegate
{
    class Program
    {
        static void Main()
        {
            Action<int, int> calc = (x, y) =>
            {
                Console.WriteLine(x + y);
            };
            calc(3, 4);
        }
    }
}
