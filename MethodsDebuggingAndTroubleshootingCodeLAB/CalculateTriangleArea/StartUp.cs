

namespace CalculateTriangleArea
{
    using System;

    public class StartUp
    {
        static double CalculateTriangleArea(double width, double height)
        {
            return width * height / 2;
        }
        public static void Main()
        {
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double triangleArea = CalculateTriangleArea(width, height);
            Console.WriteLine(triangleArea);
        }
    }
}
