using System;

namespace GeekHunterSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;

            while (x <= 20)
            {
                double m = 0;

                double s = 2;
                double e = x;

                while (e - s > 0.0001)
                {
                    m = (s + e) / 2;

                    if (m * m > x)
                        e = m;
                    else if (m * m < x)
                        s = m;
                }

                Console.WriteLine(m.ToString("0.000"));

                x++;
            }
        }
    }
}
