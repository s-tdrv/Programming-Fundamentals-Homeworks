namespace CubeProperties
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            double sideOfCube = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            double result = 0.0;
            if (parameter == "face")
            {
                result = FaceDiagonals(sideOfCube);
                Console.WriteLine($"{result:f2}");
            }
            else if (parameter == "space")
            {
                result = SpaceDiagonals(sideOfCube);
                Console.WriteLine($"{result:f2}");
            }
            else if (parameter == "volume")
            {
               result = VolumeOfCube(sideOfCube);
                Console.WriteLine($"{result:f2}");
            }
            else if (parameter == "area")
            {
                result = SurfaceArea(sideOfCube);
                Console.WriteLine($"{result:f2}");
            }
        }

        private static double FaceDiagonals(double side)
        {
            double face = Math.Sqrt(2 * (side * side));
            return face;
        }

        private static double SpaceDiagonals(double side)
        {
            double space = Math.Sqrt(3 * (side * side));
            return space;
        }

        private static double VolumeOfCube(double side)
        {
            double volume = side * side * side;
            return volume;
        }

        private static double SurfaceArea(double side)
        {
            double area = 6 * (side * side);
            return area;
        }
    }
}
