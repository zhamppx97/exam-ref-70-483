using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_17_Using_Parallel_Break
{
    class Program
    {
        public static void Main()
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                if (i == 500)
                {
                    Console.WriteLine("Breaking loop");
                    loopState.Break();
                }
                return;
            });
        }
    }
}
