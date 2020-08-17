using System;
using System.Threading;

namespace Listing_1_3_Using_the_ParameterizedThreadStart
{
    class Program
    {
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }

        public static void Main()
        {
            // In this case, the value 5 is passed to the ThreadMethod as an object.
            // You can cast it to the expected type to use it in your method.
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
        }
    }
}
