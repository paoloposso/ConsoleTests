using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChocolateFeast
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int[] saida = new int[t];

            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int c = Convert.ToInt32(tokens_n[1]);
                int m = Convert.ToInt32(tokens_n[2]);

                int total = 0;
                int adicional = 0;

                total = n / c;

                adicional = total / m;

                int resto = total % m;

                total += adicional;

                total += (resto + adicional) / m;

                saida[a0] = total;
            }

            for (int a0 = 0; a0 < t; a0++)
            {
                Console.WriteLine(saida[a0]);
            }
        }
    }
}
