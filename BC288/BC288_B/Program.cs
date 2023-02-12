using System;

namespace BC288_B
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            (int N, int K) = (int.Parse(s[0]), int.Parse(s[1]));
            string[] sis = new string[K];
            for (int i = 0; i < N; i++)
            {
                string input = Console.ReadLine();
                if (i < K)
                {
                    sis[i] = input;
                }
            }

            Array.Sort(sis);

            for (int i = 0; i < K; i++)
            {
                Console.WriteLine(sis[i]);
            }
        }
    }
}
