using System;
using System.Collections.Generic;

namespace BC288_A1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            List<long> list = new List<long>();

            for (int i = 0; i < N; i++)
            {
                string[] s = Console.ReadLine().Split(' ');
                list.Add(long.Parse(s[0]) + long.Parse(s[1]));
            }

            foreach (long l in list)
            {
                Console.WriteLine(l);
            }
        }
    }
}
