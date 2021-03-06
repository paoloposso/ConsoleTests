﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngryProfessor
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int a0 = 0; a0 < t; a0++)
            {
                string[] tokens_n = Console.ReadLine().Split(' ');
                int n = Convert.ToInt32(tokens_n[0]);
                int k = Convert.ToInt32(tokens_n[1]);

                string[] a_temp = Console.ReadLine().Split(' ');
                int[] a = Array.ConvertAll(a_temp, Int32.Parse);

                int totalAlunosEmTempo = 0;

                for (int i = 0; i < n; i++)
                {
                    if (a[i] <= 0)
                    {
                        totalAlunosEmTempo++;
                    }
                }

                if (totalAlunosEmTempo < k)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }

            Console.ReadKey();
        }
    }
}
