using System;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Console.WriteLine(SimpleRecursion(4));
        }

        private static int SimpleRecursion(int n)
        {
            if(n == 0)  // Base case
                return -1;
            else        // Recursive case
                return SimpleRecursion(n - 1);
        }
    }
}
