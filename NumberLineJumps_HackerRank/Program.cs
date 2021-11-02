using System;

namespace NumberLineJumps_HackerRank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1 = 42;
            int v1 = 3;
            int x2 = 94;
            int v2 = 2;
            string s = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(s);
        }

        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            string no = "NO";
            string yes = "YES";

            for (int i = 0; i < 5000; i++)
            {
                x1 += v1;
                x2 += v2;
                if (x1 == x2)
                {
                    break;
                } 
                    
            }

            if (x1 == x2)
            {
                return yes;
            }
            return no;
        }
    }
}
