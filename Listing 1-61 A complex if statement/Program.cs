using System;

namespace Listing_1_61_A_complex_if_statement
{
    class Program
    {
        static void Main()
        {
            Check('a');
        }

        static void Check(char input)
        {
            if (input == 'a'
                || input == 'e'
                || input == 'i'
                || input == 'o'
                || input == 'u')
            {
                Console.WriteLine("Input is a vowel");
            }
            else
            {
                Console.WriteLine("Input is a consonant");
            }
        }
    }
}
