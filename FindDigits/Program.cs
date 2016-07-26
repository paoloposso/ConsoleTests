using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int[] resultado = new int[t];

            for (int a0 = 0; a0 < t; a0++)
            {
                int n = Convert.ToInt32(Console.ReadLine());

                string valor = n.ToString();

                int contador = 0;

                for (int j = 0; j < valor.Length; j++)
                {
                    int digito = int.Parse(valor[j].ToString());

                    if (digito != 0 && n % digito == 0)
                        contador++;
                }

                resultado[a0] = contador;
            }

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(resultado[i]);
            }

            Console.ReadKey();
        }
    }
}
