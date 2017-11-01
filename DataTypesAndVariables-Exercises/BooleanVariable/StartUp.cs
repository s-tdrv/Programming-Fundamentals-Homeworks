

namespace BooleanVariable
{
    using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            bool newInput = Convert.ToBoolean(input);
            if (newInput == true)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
            

        }
    }
}
