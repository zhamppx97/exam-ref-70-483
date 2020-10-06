using System;

namespace Listing_1_76_A_multicast_delegate
{
    class Program
    {
        public static void MethodOne()
        {
            Console.WriteLine("MethodOne");
        }

        public static void MethodTwo()
        {
            Console.WriteLine("MethodTwo");
        }

        public delegate void Del();

        public static void Multicast()
        {
            Del d = MethodOne;
            d += MethodTwo;
            d();
        }

        static void Main()
        {
            Multicast();
        }
    }
}
