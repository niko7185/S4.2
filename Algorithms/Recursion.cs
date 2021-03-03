using System;
using System.Collections.Generic;
using System.Text;
using System.Numerics;
using System.Linq;
using System.Diagnostics;

namespace Algorithms
{
    public class Recursion
    {

        public static int SimpleRecursion(int n)
        {
            if(n == 0)
                return -1;

            return SimpleRecursion(n - 1);
        }

        public static int Fibonacci(int n)
        {
            if(n < 2)
                return n;

            return Fibonacci(n - 1) + Fibonacci(n - 2);
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

            if(num <= 1)
                return 1;

            return num * Faculty(num - 1);

        }

        /*
        public static List of exeptions GetExceptions(exception)
            //Base Case
            if(Inner exeptions exists)
                exceptions = new list of exeptions
                add exeption to exeptions
                return exceptions

            //Recursive Case
            allExceptions = GetExceptions(Inner exeptions) as list
            add exeption to allExceptions
            return allExceptions
        */

        public static IEnumerable<Exception> GetExceptions(Exception exception)
        {

            if(exception.InnerException == null)
            {

                List<Exception> exceptions = new List<Exception>();
                exceptions.Add(exception);

                return exceptions;

            }

            List<Exception> allExceptions = GetExceptions(exception.InnerException).ToList();

            allExceptions.Add(exception);

            return allExceptions;

        }

    }
}
