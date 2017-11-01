namespace ConvertFromBaseNToBase10
{
    using System;
    using System.Numerics;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = Console.ReadLine()
                .Trim()
                .Split();

            int n = int.Parse(input[0]);
            char[] number = input[1].ToCharArray();


            BigInteger result = new BigInteger(0);

            for (int i = 0; i < number.Length; i++)
            {
                int currentNum = (int)Char.GetNumericValue(number[i]);
                result += currentNum * BigInteger.Pow(n, number.Length - i - 1);
            }

            Console.WriteLine(result);
        }
    }
}

