using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLane
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split(' ');

            int[] entrada = Array.ConvertAll(temp, int.Parse);

            int numTestes = entrada[1];

            temp = Console.ReadLine().Split(' ');
            entrada = Array.ConvertAll(temp, int.Parse);

            int[] saida = new int[numTestes];

            for (int i = 0; i < numTestes; i++)
            {
                int menorLargura = 3;

                temp = Console.ReadLine().Split(' ');
                int[] teste = Array.ConvertAll(temp, int.Parse);

                for (int j = teste[0]; j <= teste[1]; j++)
                {
                    if (entrada[j] < menorLargura)
                        menorLargura = entrada[j];
                    if (entrada[j] == 1)
                        break;
                }

                saida[i] = menorLargura;
            }

            for (int i = 0; i < numTestes; i++)
            {
                Console.WriteLine(saida[i]);
            }
        }
    }
}
