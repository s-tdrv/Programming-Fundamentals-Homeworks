namespace GeometryCalculator
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string figureType = Console.ReadLine();

            if (figureType == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = Triangle(side, height);
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double area = Square(side);
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double height = double.Parse(Console.ReadLine());
                double area = Rectangle(width, height);
                Console.WriteLine($"{area:f2}");
            }
            else if (figureType == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double area = Circle(radius);
                Console.WriteLine($"{area:f2}");
            }
        }

        private static double Triangle(double side, double height)
        {
            double area = (side * height) / 2;
            return area;
        }

        private static double Square(double side)
        {
            double area = side * side;
            return area;
        }

        private static double Rectangle(double width, double height)
        {
            double area = width * height;
            return area;
        }

        private static double Circle(double radius)
        {
            double area = Math.PI * radius * radius;
            return area;
        }
    }
}
