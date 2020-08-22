using System;
using System.Linq;

namespace Listing_1_22_Using_As_Parallel
{
    class Program
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0, 10);
            var parallelResult = numbers.AsParallel().Where(i => i % 2 == 0).ToArray();
        }
    }
}
