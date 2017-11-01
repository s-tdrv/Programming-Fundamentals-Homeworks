
namespace VariableInHexadecimalFormat
{
    using System;
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
            int newNum = Convert.ToInt32(num1, 16);
            Console.WriteLine(newNum);
        }
    }
}
