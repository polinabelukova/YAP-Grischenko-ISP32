using System;
using System.Linq;

namespace ProgLang
{
    class Program
    {
        static void Main()
        {
            double[] x = Console.ReadLine().Split(' ').Select(x=>double.Parse(x)).ToArray();
            double a= double.Parse(Console.ReadLine());
            for (int i = 0; i < x.Length; i++)
            {
                int y = (int)x[i];
                if (y % 2 != 0&&x[i]>a)
                {
                    Console.Write(x[i]+" ");
                }
            }
            Array.Sort(x);
            Console.WriteLine();
            for(int i = 0; i < x.Length; i++)
            {
                int g=(int)x[i];
                if (g % 2 == 0)
                {
                    Console.Write(x[i]+" ");
                }
            }

        }
    }
}
