using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SherlockSquares
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());
            int[] arrresult = new int[t];
            
            for (int a0 = 0; a0 < t; a0++)
            {
                string[] entradaTemp = Console.ReadLine().Split(' ');

                int[] entrada = Array.ConvertAll(entradaTemp, int.Parse);

                int menor = entrada[0];
                int maior = entrada[1];

                double maiorRaiz = Convert.ToInt32(Math.Floor(Math.Sqrt(maior)));
                double menorRaiz = Convert.ToInt32(Math.Ceiling(Math.Sqrt(menor)));
                                                   
                arrresult[a0] = Convert.ToInt32(maiorRaiz - menorRaiz + 1);                
            }

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine(arrresult[i]);
            }

            Console.ReadKey();
        }
    }
}
