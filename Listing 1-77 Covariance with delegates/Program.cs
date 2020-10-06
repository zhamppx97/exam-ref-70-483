using System;
using System.IO;

namespace Listing_1_77_Covariance_with_delegates
{
    class Program
    {
        public delegate TextWriter CovarianceDel();
        public static StreamWriter MethodStream() { return null; }
        public static StringWriter MethodString() { return null; }

        static void Main()
        {
            CovarianceDel del;
            del = MethodStream;
            del = MethodString;
        }
    }
}
