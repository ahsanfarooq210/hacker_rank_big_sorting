using System;

namespace hacker_rank_big_sorting
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string[] a = new string[n];
            
            for (int i = 0; i < n; ++i) a[i] = Console.ReadLine();

            Array.Sort(a, (s1, s2) =>
            {
                int l = s1.Length - s2.Length;
                return (l != 0) ? l : string.Compare(s1, s2, StringComparison.OrdinalIgnoreCase);
            });

            for (int i = 0; i < n; ++i) Console.WriteLine(a[i]);
        }
    }
}