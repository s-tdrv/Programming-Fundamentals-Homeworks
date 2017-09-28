using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5DifferentNumbers
{
    public class StartUp
    {
        public static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int counter = 0;

            for (int i = a; i <= b; i++)
            {
                for (int j = i; j <= b; j++)
                {
                    for (int k = j; k <= b; k++)
                    {
                        for (int l = k; l <= b; l++)
                        {
                            for (int m = l; m <= b; m++)
                            {

                                
                               if (a <= i && i < j && j < k && k < l && l < m && m <= b )
                               {
                                   Console.WriteLine($"{i} {j} {k} {l} {m}");
                                   counter++;
                               }
                               
                            }
                        }
                    }
                }
            }
            if (counter == 0)
            {
                Console.WriteLine("No");
            }
            
        }
    }
}
