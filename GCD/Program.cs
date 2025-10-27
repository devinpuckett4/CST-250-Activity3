using System;

namespace GCD
{
    public static class Utility
    {
        internal static int GreatestCommonDivisor(int a, int b)
        {
            if (b == 0) return Math.Abs(a);
            int r = a % b;
            Console.WriteLine($"{a} % {b} = {r}");
            return GreatestCommonDivisor(b, r);
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter first integer: ");
            int a = int.TryParse(Console.ReadLine(), out int av) ? av : 0;

            Console.Write("Enter second integer: ");
            int b = int.TryParse(Console.ReadLine(), out int bv) ? bv : 0;

            int g = Utility.GreatestCommonDivisor(a, b);
            Console.WriteLine($"GCD({a}, {b}) = {g}");
        }
    }
}
