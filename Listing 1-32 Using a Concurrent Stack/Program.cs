using System;
using System.Collections.Concurrent;

namespace Listing_1_32_Using_a_Concurrent_Stack
{
    class Program
    {
        static void Main()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();
            stack.Push(97);
            
            if (stack.TryPop(out int result))
                Console.WriteLine("Popped: {0}", result);

            stack.PushRange(new int[] { 1, 2, 3 });
            int[] values = new int[2];
            stack.TryPopRange(values);

            foreach (int i in values)
                Console.WriteLine(i);
        }
    }
}
