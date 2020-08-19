using System;
using System.Threading;

namespace Listing_1_6_Using_ThreadLocal_T
{
    class Program
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() => 
        {
            return Thread.CurrentThread.ManagedThreadId;
        });

        public static void Main()
        {
            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread A: {0}", i);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread B: {0}", i);
                }
            }).Start();

            Console.ReadKey();
        }
    }
}
