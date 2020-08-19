using System;
using System.Threading.Tasks;

namespace Listing_1_13_Using_a_TaskFactory
{
    class Program
    {
        public static void Main()
        {
            Task<Int32[]> parent = Task.Run(() =>
            {
                var resutls = new Int32[3];
                TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent,
                    TaskContinuationOptions.ExecuteSynchronously);

                tf.StartNew(() => resutls[0] = 0);
                tf.StartNew(() => resutls[1] = 1);
                tf.StartNew(() => resutls[2] = 2);

                return resutls;
            });

            var finalTask = parent.ContinueWith(parentTask =>
            {
                foreach (int i in parentTask.Result)
                {
                    Console.WriteLine(i);
                }
            });

            finalTask.Wait();
        }
    }
}
