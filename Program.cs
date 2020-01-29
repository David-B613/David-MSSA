using System;

namespace Giraffe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fib(0)); //0
            Console.WriteLine(Fib(5)); //5
            Console.WriteLine(Fib(6)); //8
        }
        static int Fib(int n, int a = 0, int b = 1)
        {
            if (n <= 0) return a;

            return Fib(n - 1, b, a + b);

        }
        // Count to 10 
        static void DoAloop(int iteration)
        {
            // Base Case
            if (iteration <= 0) return;


            Console.WriteLine();
            
            // Inductive/Induction/Recursive/Alterntive case 
            DoAloop(iteration - 1);
        }
    }
}
