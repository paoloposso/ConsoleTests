using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CutSticks
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);

            int restantes = n;

            Console.WriteLine(restantes);

            while (true)
            {
                if (restantes == 1)
                    break;

                int menor = 0;
                int maior = 0;

                //encontrar menor
                for (int i = 0; i < n; i++)
                {
                    if ((arr[i] < menor && arr[i] > 0) || menor == 0)
                        menor = arr[i];

                    if ((arr[i] > maior) || maior == 0)
                        maior = arr[i];
                }

                if (maior == menor)
                    break;

                for (int i = 0; i < n; i++)
                {
                    if (arr[i] > 0)
                    {
                        arr[i] = arr[i] - menor;

                        if (arr[i] == 0)
                            restantes--;
                    }
                }
                Console.WriteLine(restantes);                
            }
            Console.Read();
        }
    }
}
