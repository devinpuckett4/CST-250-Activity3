using System;

namespace CountToOne
{
    internal static class Utility
    {
        internal static int CountToOneRec(int n)
        {
            Console.WriteLine($"n = {n}");
            if (n == 1) return 1;
            if (n <= 0) { Console.WriteLine("Start with a positive integer."); return n; }
            if (n % 2 == 0) return CountToOneRec(n / 2);
            return CountToOneRec(n + 1);
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a positive integer: ");
            if (int.TryParse(Console.ReadLine(), out int n) && n > 0)
                Utility.CountToOneRec(n);
            else
                Console.WriteLine("Please enter a valid positive integer.");
        }
    }
}
