using System;
using System.IO;

namespace Listing_1_78_Contravariance_with_delegates
{
    class Program
    {
        public static void DoSomething(TextWriter tw) { }
        public delegate void ContravarianceDel(StreamWriter sw);
        
        public static void Main()
        {
            ContravarianceDel del = DoSomething;
        }
    }
}
