using System;
using System.Threading.Tasks;

namespace Listing_1_10_Adding_a_continuation
{
    class Program
    {
        public static void Main()
        {
            Task<int> t = Task.Run(() =>
            {
                return 97;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });
            Console.WriteLine(t.Result);
        }
    }
}
