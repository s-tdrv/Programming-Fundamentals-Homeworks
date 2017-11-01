

namespace VowelOrDigit
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            char input = char.Parse(Console.ReadLine().ToLower());

            if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            {
                Console.WriteLine("vowel");
            }
            else if (input >= 48 && input <= 57)
            {
                Console.WriteLine("digit");
            }
            else
            {
                Console.WriteLine("other");
            }
        }
    }
}
