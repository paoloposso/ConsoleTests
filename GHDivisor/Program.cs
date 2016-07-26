using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GHDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] arrresult = new int[t];

            for (int i = 0; i < t; i++)
            {
                string[] entradaTemp = Console.ReadLine().Split(' ');

                int[] entrada = Array.ConvertAll(entradaTemp, int.Parse);
                int menor = 0;
                int maior = 0;
                int menorDiv = 0;

                if (entrada[0] < entrada[1])
                {
                    menor = entrada[0];
                    maior = entrada[1];
                }
                else
                {
                    menor = entrada[1];
                    maior = entrada[0];
                }

                if (menor == 0)
                    menorDiv = maior;
                else
                {
                    int resto = maior % menor;

                    while (resto != 0)
                    {
                        maior = menor;
                        menor = resto;

                        resto = maior % menor;

                        if (resto == 0)
                            break;
                    }

                    menorDiv = menor;
                }

                arrresult[i] = menorDiv;
            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(arrresult[i]);
            }
            Console.Read();
        }
    }
}
