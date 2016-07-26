using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Candies
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            int qtdAtual = 0;
            int ratingAnterior = 0;
            int total = 0;
            int qtdAnterior = 0;

            for (int i = 0; i < t; i++)
            {
                int ratingAtual = Convert.ToInt32(Console.ReadLine());

                if (ratingAtual > ratingAnterior)
                    qtdAtual++;
                else
                {
                    qtdAtual = 1;

                    if (ratingAtual < ratingAnterior && qtdAnterior == 1)
                        total++;
                }

                total += qtdAtual;
                
                ratingAnterior = ratingAtual;
                qtdAnterior = qtdAtual;
            }

            Console.WriteLine(total);
        }
    }
}
