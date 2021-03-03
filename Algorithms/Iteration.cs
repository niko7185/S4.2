using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Numerics;
using System.Text;

namespace Algorithms
{
    public class Iteration
    {

        public static int Fibonacci(int n)
        {

            int result = 1;
            int previous = 0;

            for(int i = 1; i < n; i++)
            {

                int num = result;

                result += previous;

                previous = num;
            }

            return result;
        }

        public static string FibonacciSequence()
        {

            string result = "";

            for(int i = 2; i <= 45; i++)
            {
                Stopwatch watch = Stopwatch.StartNew();

                Int64 fibonacci = Fibonacci(i);

                watch.Stop();

                result += $"{i}: Fibonacci:{fibonacci} Time:{watch.Elapsed.Ticks}\n";

            }

            return result;
        }

        public static string FacultySequence(int length)
        {
            string message = "";

            for(int i = 1; i <= length; i++)
            {
                Stopwatch watch = Stopwatch.StartNew();

                BigInteger result = Faculty(i);

                watch.Stop();

                message += $"{i}: Faculty: {result} Time:{watch.Elapsed.Ticks}\n";
            }

            return message;
        }

        public static BigInteger Faculty(int num)
        {

            BigInteger result = 1;

            for(int i = 1; i <= num; i++)
            {
                result *= i;
            }

            return result;
        }

    }
}
