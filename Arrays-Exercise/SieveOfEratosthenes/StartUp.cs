namespace SieveOfEratosthenes
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            bool[] array = new bool[n + 1];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = true;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (array[i])
                {
                    for (int j = i * i; j < array.Length; j+=i)
                    {
                        array[j] = false;
                    }

                }
            }
            for (int k = 2; k < array.Length; k++)
            {
                if (array[k] == true)
                { Console.Write(k + " "); }
            }
            Console.WriteLine();

        }
    }
}
