using System;
using System.Collections.Generic;

namespace Listing_1_72_Changing_items_in_a_foreach
{
    class Program
    {
        class Person
        {
            public string Firstname { get; set; }
            public string Lastname { get; set; }
        }

        void CannotChangeForeachIterationVariable()
        {
            var people = new List<Person>
            {
                new Person() { Firstname = "John", Lastname = "Doe" },
                new Person() { Firstname = "Jane", Lastname = "Doe" }
            };

            foreach (Person p in people)
            {
                p.Lastname = "Changed"; // This is allowed
                // p = new Person(); // This gives a compile error
            }
        }

        static void Main()
        {
            Console.WriteLine("Hello World!");
        }
    }
}
