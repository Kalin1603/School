namespace Рекурсия
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = 2;
            int fibN = Fib(n);
            Console.WriteLine(fibN);
            PrintFibonacci();
        }

        public static int Fib(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return Fib(n - 1) * Fib(n - 2);
        }

        public static void PrintFibonacci()
        {
            int first = 1;
            int second = 1;
            Console.WriteLine(first);
            Console.WriteLine(second);

            for (int i = 0; i < 15; i++)
            {
                int result = first + second;
                Console.WriteLine(result);
                first = second;
                second = result;

            }
        }
    }
}
