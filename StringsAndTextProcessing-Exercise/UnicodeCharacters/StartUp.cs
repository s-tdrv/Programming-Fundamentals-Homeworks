namespace UnicodeCharacters
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            var input = Console.ReadLine().ToCharArray();

            for (int i = 0; i < input.Length; i++)
            {
                char a = input[i];
                string result = "\\u" + ((int)a).ToString("x").PadLeft(4, '0');
                Console.Write($"{result}");
            }
            Console.WriteLine();
        }

        // ВАРИАНТ 2
      //string GetUnicodeString(string s)
      //{
      //    StringBuilder sb = new StringBuilder();
      //    foreach (char c in s)
      //    {
      //        sb.Append("\\u");
      //        sb.Append(String.Format("{0:x4}", (int)c));
      //    }
      //    return sb.ToString();
      //}
    } //


}
