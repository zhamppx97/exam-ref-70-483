using System;
using System.Collections.Generic;

namespace Listing_1_73_The_compiler_generated_code_for_a_foreach_loop
{
    class Program
    {
        class Person
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
        }

        static void Main()
        {
            var people = new List<Person>
            {
                new Person() { Firstname = "John", Lastname = "Doe" },
                new Person() { Firstname = "Jane", Lastname = "Doe" }
            };

            List<Person>.Enumerator e = people.GetEnumerator();

            try
            {
                Person v;
                while (e.MoveNext())
                {
                    v = e.Current;
                }
            }
            finally
            {
                System.IDisposable d = e as System.IDisposable;
                if (d != null) d.Dispose();
            }
        }
    }
}
