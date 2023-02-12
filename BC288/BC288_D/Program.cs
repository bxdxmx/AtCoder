using System;
using System.Collections.Generic;
using System.Linq;

namespace BC288_D
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int N = input[0];
            int K = input[1];
            long[] A = Console.ReadLine().Split().Select(long.Parse).ToArray();
            int Q = int.Parse(Console.ReadLine());

            List<string> res = new List<string>();

            for (int i = 0; i < Q; i++)
            {
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
                int l = input[0]-1;
                int r = input[1]-1;
                long[] A2 = A[l..(r + 1)];

                for (int j = 1; j < A2.Length - K + 1; j += K)
                {
                    long n = A2[j - 1] - A2[j];
                    if (n == 0)
                    {
                        continue;
                    }

                    for (int k = 0; k < K; k++)
                    {
                        A2[j + k] += n;
                    }

                    long n2 = A2[j] - A2[j + 1];
                    if (n2 == 0)
                    {
                        continue;
                    }

                    for (int k = 0; k < K; k++)
                    {
                        A2[j +1 + k] += n2;
                    }
                }

                long nn = A2[A2.Length - K];

                for( int j = A2.Length - K ; j < A2.Length; j++)
                {
                    if (A2[j] != nn)
                    {
                        res.Add("No");
                        nn = long.MaxValue;
                        break;
                    }
                }

                if (nn != long.MaxValue)
                {
                    res.Add("Yes");
                }
            }

            res.ForEach(s => Console.WriteLine(s));
        }
    }
}
