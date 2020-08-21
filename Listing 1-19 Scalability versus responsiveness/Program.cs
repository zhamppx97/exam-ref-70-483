using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Listing_1_19_Scalability_versus_responsiveness
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Hello World!");
        }

        public static Task SleepAsyncA(int millisecondsTimeout)
        {
            return Task.Run(() => Thread.Sleep(millisecondsTimeout));
        }

        public static Task SleepAsyncB(int millisecondsTimeout)
        {
            TaskCompletionSource<bool> tcs = null;
            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);
            return tcs.Task;
        }
    }
}
