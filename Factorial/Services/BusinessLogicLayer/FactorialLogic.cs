using System.Numerics;

namespace Factorial.Services.BusinessLogicLayer
{
    internal class FactorialLogic
    {
        internal BigInteger SolveIterativeFactorial(int n)
        {
            if (n < 0) return -1;
            BigInteger result = 1;
            for (int i = 2; i <= n; i++) result *= i;
            return result;
        }

        internal BigInteger SolveRecursiveFactorial(int n)
        {
            if (n < 0) return -1;
            return (n <= 1) ? 1 : n * SolveRecursiveFactorial(n - 1);
        }
    }
}
