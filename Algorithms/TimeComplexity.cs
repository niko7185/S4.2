using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Algorithms
{
    public class TimeComplexity
    {

        //O(n), 2n + 1n + 2
        public static int Sum(int[] array)
        {
            int total = 0;

            foreach(int element in array)
            {
                total += element;
            }

            return total;
        }

        //O(1), 3
        public static string Find(string[] array, int index)
        {
            string value = array[index];

            return value;
        }

        //O(n), 2n + 1n + 1
        public static bool Contains(string[] array, string value)
        {

            foreach(string element in array)
            {
                if(element == value)
                {
                    return true;
                }
            }

            return false;
        }

        /*
         function RemoveAt(array, index)
            newArray = list
            for each number in array length
                if number is not index
                    add to newArry
            return newArray as array
         */
        //O(n), 2n + 3n + 2

        public static string[] RemoveAt(string[] array, int index)
        {
            List<string> newArray = new List<string>();

            for(int i = 0; i < array.Length; i++)
            {
                if(i != index)
                {
                    newArray.Add(array[i]);
                }
            }

            return newArray.ToArray();

        }

        /*
         function RemoveByValue(array, value)
            newArray = list
            for each element in array length
                if element is not value
                    add to newArry
            return newArray as array
         */
        //O(n), 2n + 2n + 2

        public static string[] RemoveByValue(string[] array, string value)
        {
            List<string> newArray = new List<string>();

            foreach(string element in array)
            {
                if(element != value)
                {
                    newArray.Add(value);
                }
            }

            return newArray.ToArray();

        }

        /*
         function Matching(array1, array2)
            newArray = list
            minLength = lowest value(array1 length, array2 length)
            for each number in minLength
                if array1[number] equals array2[number]
                    add to newArry
            return newArray as array
         */
        //O(n), 2n + 3n + 2n + 7

        public static string[] Matching(string[] array1, string[] array2)
        {
            List<string> newArray = new List<string>();
            int minLength = Math.Min(array1.Length, array2.Length);

            for(int i = 0; i < minLength; i++)
            {
                if(array1[i] == array2[i])
                {
                    newArray.Add(array1[i]);
                }
            }

            return newArray.ToArray();

        }

        //O(n), 2n
        public static BigInteger Factorial(int n)
        {
            if(n == 0)
                return 1;

            return n * Factorial(n - 1);

        }

        //O(n2), 2n + 2n * n + 4n * n + 6n * n + 2n * n + 3n * n + 1
        public static int[] Sort(int[] array)
        {

            for(int n = 0; n < array.Length - 1; n++)
            {
                for(int i = 0; i < array.Length - 1; i++)
                {

                    if(array[i] > array[i + 1])
                    {
                        int[] swappedArray = Swap(array[i], array[i + 1]);

                        array[i] = swappedArray[0];
                        array[i + 1] = swappedArray[1];
                    }
                }
            }

            return array;

        }

        /*
         function Swap(value1, value2)
            swappedArray = [value2, value1]
            return swappedArray
         */
        //O(1), 2

        public static int[] Swap(int value1, int value2)
        {

            int[] swappedArray = new int[] { value2, value1 };

            return swappedArray;

        }

    }
}
