using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveThePrisoner
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int[] saida = new int[t];

            for (int a0 = 0; a0 < t; a0++)
            {
                string[] entrada = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(entrada[0]);
                int m = Convert.ToInt32(entrada[1]);
                int s = Convert.ToInt32(entrada[2]);

                int resto = m % n;

                int envenenado = resto + s - 1;

                if (envenenado > n)
                    envenenado = envenenado - n;

                if (envenenado == 0)
                    envenenado = n;

                saida[a0] = envenenado;
            }

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(saida[i]);
            }
        }
    }
}
