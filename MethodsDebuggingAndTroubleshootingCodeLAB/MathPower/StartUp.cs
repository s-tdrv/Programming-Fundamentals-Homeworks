namespace MathPower
{
    using System;

    public class StartUp
    {

        static double RiseToPower(double number, int power)
        {
            double result = 0d;
            result = Math.Pow(number, power);
            return result;
        }
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            double result = RiseToPower(number, power);
            Console.WriteLine(result);
        }
    }
}
