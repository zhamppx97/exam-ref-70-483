using System;
using System.Collections.Concurrent;

namespace Listing_1_30_Using_a_Concurrent_Bag
{
    class Program
    {
        static void Main()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>
            {
                80, 90
            };

            int result;
            if (bag.TryTake(out result))
                Console.WriteLine(result);

            if (bag.TryPeek(out result))
                Console.WriteLine("There is a next item: {0}", result);
        }
    }
}
