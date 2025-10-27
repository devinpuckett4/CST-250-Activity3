using System;
using System.Numerics;
using Factorial.Services.BusinessLogicLayer;

namespace Factorial
{
    internal static class Utility
    {
        internal static int ReadInt(string prompt)
        {
            Console.Write(prompt);
            return int.TryParse(Console.ReadLine(), out int v) ? v : -1;
        }
    }

    internal class Program
    {
        static void Main()
        {
            var logic = new FactorialLogic();
            int n = Utility.ReadInt("Enter n (0..?): ");
            if (n < 0) { Console.WriteLine("Invalid."); return; }

            BigInteger it = logic.SolveIterativeFactorial(n);
            BigInteger rec = logic.SolveRecursiveFactorial(n);

            Console.WriteLine($"Iterative: {it}");
            Console.WriteLine($"Recursive: {rec}");
        }
    }
}
