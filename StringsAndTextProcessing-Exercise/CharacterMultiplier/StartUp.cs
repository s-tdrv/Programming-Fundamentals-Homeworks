namespace CharacterMultiplier
{
    using System;

    public class StartUp
    {
       public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            string str1 = input[0];
            string str2 = input[1];
            var sum = 0;

            int minLength = Math.Min(str1.Length, str2.Length);
            int maxLength = Math.Max(str1.Length, str2.Length);

            
            for (int i = 0; i < minLength; i++)
            {
               var multiplier = str1[i] * str2[i];
                sum += multiplier;
            }
            if (maxLength == str1.Length)
            {
                for (int i = minLength; i < maxLength; i++)
                {
                    sum += str1[i];
                }
            }
            else if (maxLength == str2.Length)
            {
                for (int j = minLength; j < maxLength; j++)
                {
                    sum += str2[j];
                }
            }


            Console.WriteLine(sum);
        }
    }
}
