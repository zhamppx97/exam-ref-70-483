using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_16_Using_Parallel_For_and_Parallel_Foreach
{
    class Program
    {
        public static void Main()
        {
            Task<int>[] tasks = new Task<int>[3];
            tasks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
            tasks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
            tasks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });

            Parallel.For(0, 10, i =>
              {
                  Thread.Sleep(1000);
                  Console.WriteLine(i);
              });

            var numbers = Enumerable.Range(0, 10);
            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
                Console.WriteLine(i);
            });
        }
    }
}
