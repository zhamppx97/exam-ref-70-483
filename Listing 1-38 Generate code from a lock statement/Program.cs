using System;
using System.Threading;

namespace Listing_1_38_Generate_code_from_a_lock_statement
{
    class Program
    {
        static void Main()
        {
            object gate = new object();
            bool _lockTaken = false;
            try
            {
                Monitor.Enter(gate, ref _lockTaken);
            }
            finally
            {
                if (_lockTaken)
                    Monitor.Exit(gate);
            }
        }
    }
}
