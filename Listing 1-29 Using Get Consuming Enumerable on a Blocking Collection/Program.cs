using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace Listing_1_29_Using_Get_Consuming_Enumerable_on_a_Blocking_Collection
{
    class Program
    {
        static void Main()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();
            Task read = Task.Run(() =>
            {
                foreach (string v in col.GetConsumingEnumerable())
                {
                    Console.WriteLine(v);
                }
            });
        }
    }
}
