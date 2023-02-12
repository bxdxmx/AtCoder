using System;
using System.Linq;

namespace AtCoder_Beginner_Contest_281_C
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine().Split(' ');

            int N = int.Parse(s[0]);
            long T = long.Parse(s[1]);
            long[] a = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
            long sum = a.Sum();

            long t = T % sum;

            int i = 0;

            while (true)
            {
                if( t > a[i])
                {
                    t -= a[i];
                    i = (i+1)%N;
                }
                else
                {
                    Console.WriteLine("{0} {1}", i + 1, t);
                    return;
                }
            }
        }
    }
}
