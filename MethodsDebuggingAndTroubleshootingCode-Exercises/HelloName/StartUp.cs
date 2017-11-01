

namespace HelloName
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string name = Console.ReadLine();
            Console.WriteLine(PrintName(name));
        }
        private static string PrintName(string name)
        {        
            return $"Hello, {name}!";
        }
    }
}
