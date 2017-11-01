

namespace EnglishNameOfLastDigit
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine(EnglishName(number));
        }

        private static string EnglishName(long number)
        {
            long lastDigit = Math.Abs(number % 10);
            string englishName = "";
            switch (lastDigit)
            {
                case 0:
                    englishName = "zero";
                    break;
                case 1:
                    englishName = "one";
                    break;
                case 2:
                    englishName = "two";
                    break;
                case 3:
                    englishName = "three";
                    break;
                case 4:
                    englishName = "four";
                    break;
                case 5:
                    englishName = "five";
                    break;
                case 6:
                    englishName = "six";
                    break;
                case 7:
                    englishName = "seven";
                    break;
                case 8:
                    englishName = "eight";
                    break;
                case 9:
                    englishName = "nine";
                    break;

                    
            }
            return englishName;
        }
    }
}
