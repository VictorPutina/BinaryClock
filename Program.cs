using System;

namespace BinaryClock
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;

            string hour = now.ToString("HH");
            string min = now.ToString("mm");
            string sec = now.ToString("ss");

            int h1 = int.Parse(hour[0].ToString());
            int h2 = int.Parse(hour[1].ToString());
            int m1 = int.Parse(min[0].ToString());
            int m2 = int.Parse(min[1].ToString());
            int s1 = int.Parse(sec[0].ToString());
            int s2 = int.Parse(sec[1].ToString());

            string[] bin = new string[]
            {
                Convert.ToString(h1, 2).PadLeft(4, '0'),
                Convert.ToString(h2, 2).PadLeft(4, '0'),
                Convert.ToString(m1, 2).PadLeft(4, '0'),
                Convert.ToString(m2, 2).PadLeft(4, '0'),
                Convert.ToString(s1, 2).PadLeft(4, '0'),
                Convert.ToString(s2, 2).PadLeft(4, '0')
            };

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{bin[0][i]} {bin[1][i]} | {bin[2][i]} {bin[3][i]} | {bin[4][i]} {bin[5][i]}");
            }

            Console.WriteLine();
            Console.WriteLine($"{hour} : {min} : {sec}");
            Console.ReadKey();
        }
    }
}
