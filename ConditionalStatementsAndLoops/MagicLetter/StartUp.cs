
namespace MagicLetter
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            char start = char.Parse(Console.ReadLine());
            char last = char.Parse(Console.ReadLine());
            string magic = Console.ReadLine();

            for (char i = start; i <= last; i++)
            {
                for (char j = start; j <= last; j++)
                {
                    for (char k = start; k <= last; k++)
                    {
                        string result = $"{i}{j}{k} ";

                        if (!result.Contains(magic))
                        {
                            Console.Write(result);
                        }
                    }
                }
            }
        }
    }
}
