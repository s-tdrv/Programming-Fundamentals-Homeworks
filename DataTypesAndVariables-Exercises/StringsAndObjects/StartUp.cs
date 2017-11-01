
namespace StringsAndObjects
{
    using System;

    public class StartUp
    {
       public static void Main(string[] args)
        {
            string first = "Hello";
            string second = "World";
            object obj = first + " " + second;
            string result = (string)obj;
            Console.WriteLine(result);
        }
    }
}
