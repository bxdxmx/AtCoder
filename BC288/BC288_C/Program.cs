using System;

namespace BC288_C
{
    class UnionFind
    {
        public int[] Parents { get; set; }

        public UnionFind(int n)
        {
            this.Parents = new int[n];
            for (int i = 0; i < n; i++)
            {
                this.Parents[i] = i;
            }
        }

        public int Find(int x)
        {
            if (this.Parents[x] == x)
            {
                return x;
            }

            this.Parents[x] = Find(this.Parents[x]);
            return this.Parents[x];
        }

        public bool Same(int x, int y)
        {
            return this.Find(x) == this.Find(y);
        }

        public void Union(int x, int y)
        {
            x = this.Find(x);
            y = this.Find(y);

            if (x != y)
            {
                this.Parents[y] = x;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split(' ');
            int N = int.Parse(s[0]);
            int M = int.Parse(s[1]);

            UnionFind unionFind = new UnionFind(N + 1);
            int res = 0;

            for (int i = 0; i < M; i++)
            {
                s = Console.ReadLine().Split(" ");
                int A = int.Parse(s[0]);
                int B = int.Parse(s[1]);

                if (unionFind.Same(A, B))
                {
                    res++;
                }
                else
                {
                    unionFind.Union(A, B);
                }
            }

            Console.WriteLine(res);
        }
    }
}
