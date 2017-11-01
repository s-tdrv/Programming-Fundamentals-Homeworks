

namespace IntegerToHexAndBinary
{
    using System; 

    public class StartUp
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            Console.WriteLine(Convert.ToString(input, 16).ToUpper());
            Console.WriteLine(Convert.ToString(input, 2));
            
         
           
        }
    }
}
