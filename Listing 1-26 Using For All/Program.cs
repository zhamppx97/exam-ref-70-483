using System;
using System.Linq;

namespace Listing_1_26_Using_For_All
{
    class Program
    {
        static void Main()
        {
            var numbers = Enumerable.Range(0, 20);
            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0);
            parallelResult.ForAll(e => Console.WriteLine(e));
        }
    }
}
