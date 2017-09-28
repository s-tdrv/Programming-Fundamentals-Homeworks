

namespace CountTheIntegers
    {
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int counter = 0;

            try
            {
                while (counter < 100)
                {
                    int n = int.Parse(Console.ReadLine());
                    counter++;
                }
            }
            catch (Exception)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
