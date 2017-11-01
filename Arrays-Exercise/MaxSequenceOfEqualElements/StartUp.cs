namespace MaxSequenceOfEqualElements
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int[] elements = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int len = 0;
            int bestLen = 0;
            int position = 0;

            for (int i = 0; i < elements.Length - 1; i++)
            {
                if (elements[i] == elements[i + 1])
                {
                    len++;
                    if (len > bestLen)
                    {
                        position = i - len;
                        bestLen = len;
                    }
                }
                else
                {
                    len = 0;
                }
            }
            for (int i = position + 1; i <= position + bestLen + 1; i++)
            {
                Console.Write(elements[i] + " ");
            }
            Console.WriteLine();

        }
    }
}
