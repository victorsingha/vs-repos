using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1 = Factorial(5);
            int result2 = factorial_recursion(5);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
        public static int Factorial(int n)
        {
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }
        public static int factorial_recursion(int n)
        {
            if (n == 0) return 1;
            else return (n * factorial_recursion(n - 1));
        }
    }
}
