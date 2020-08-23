using System;
using System.Linq;

namespace Listing_1_25_Making_a_parallel_query_sequential
{
    class Program
    {
        public static void Main()
        {
            var numbers = Enumerable.Range(0 ,20);
            var parallelResult = numbers.AsParallel().AsOrdered().Where(i => i % 2 == 0).AsSequential();
            foreach (int i in parallelResult.Take(5))
            {
                Console.WriteLine(i);
            }
        }
    }
}
