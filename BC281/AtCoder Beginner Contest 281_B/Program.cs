using System;
using System.Linq;

namespace AtCoder_Beginner_Contest_281_B
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();

            if (s.Length != 8)
            {
                Console.WriteLine("No");
                return;
            }

            if (!char.IsUpper(s[0]))
            {
                Console.WriteLine("No");
                return;
            }

            if (!char.IsUpper(s[^1]))
            {
                Console.WriteLine("No");
                return;
            }

            int n;
            if(!int.TryParse(s.Substring(1, 6), out n))
            {
                Console.WriteLine("No");
                return;
            }

            if( n < 100000)
            {
                Console.WriteLine("No");
                return;
            }

            Console.WriteLine("Yes");
        }
    }
}
