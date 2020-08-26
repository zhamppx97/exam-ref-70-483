using System;
using System.Collections.Concurrent;

namespace Listing_1_33_Using_a_Concurrent_Queue
{
    class Program
    {
        static void Main()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();
            queue.Enqueue(97);

            if (queue.TryDequeue(out int result))
                Console.WriteLine("Dequeued: {0}", result);
        }
    }
}
