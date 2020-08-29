using System;

namespace Listing_1_39_A_potential_problem_with_multithreaded_code
{
    class Program
    {
        private static volatile int _flag = 0;
        private static int _value = 0;

        public static void Thread1()
        {
            _value = 5;
            _flag = 1;
        }

        public static void Thread2()
        {
            if (_flag == 1)
            {
                Console.WriteLine(_value);
            }
        }

        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
