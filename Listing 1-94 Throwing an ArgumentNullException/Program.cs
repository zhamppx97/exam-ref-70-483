using System;
using System.IO;

namespace Listing_1_94_Throwing_an_ArgumentNullException
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello World!");
        }

        static string OpenAndParse(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new ArgumentException("fileName", "Filename is required");

            return File.ReadAllText(fileName);
        }
    }
}
