using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public class Sorting
    {

        public static int[] BubbleSort(int[] array)
        {

            for(int i = 1; i < array.Length; i++)
            {

                for(int j = array.Length - 1; j >= i; j--)
                {
                    if(array[j] < array[j - 1])
                    {
                        int item = array[j];

                        array[j] = array[j - 1];

                        array[j - 1] = item;
                    }
                }

            }

            return array;

        }

        public static int[] InsertionSort(int[] array)
        {

            for(int i = 1; i < array.Length; i++)
            {

                int j = i;
                int t = array[j];

                while(j > 0 && t < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = t;

            }

            return array;

        }

        public static int[] SelectionSort(int[] array)
        {

            for(int i = 0; i < array.Length - 1; i++)
            {

                int k = i;

                for(int j = i + 1; j < array.Length; j++)
                {

                    if(array[j] < array[k])
                    {
                        k = j;
                    }

                }

                int item = array[i];

                array[i] = array[k];

                array[k] = item;

            }

            return array;

        }

        public static int[] QuickSort(int[] array, int left, int right)
        {

            if(left < right)
            {

                if((right - left) <= 15)
                {

                    for(int i = left + 1; i < right + 1; i++)
                    {

                        int j = i;
                        int t = array[j];

                        while(j > left && t < array[j - 1])
                        {
                            array[j] = array[j - 1];
                            j--;
                        }

                        array[j] = t;

                    }

                }
                else
                {
                    array = Partition(array, left, right, out int pivotIndex);

                    array = QuickSort(array, left, pivotIndex - 1);

                    return QuickSort(array, pivotIndex + 1, right);

                }

            }

            return array;

        }

        private static int[] Partition(int[] array, int left, int right, out int pivotIndex)
        {

            pivotIndex = GetPivotIndex(array, left, right);

            int pivot = array[pivotIndex];

            array[pivotIndex] = array[right];

            array[right] = pivot;

            int leftMarker = left;
            int rightMarker = right - 1;

            while(leftMarker <= rightMarker)
            {

                while(leftMarker <= rightMarker && array[leftMarker] <= pivot)
                {
                    leftMarker++;
                }

                while(leftMarker <= rightMarker && array[rightMarker] >= pivot)
                {
                    rightMarker--;
                }

                if(leftMarker < rightMarker)
                {

                    int item = array[leftMarker];
                    array[leftMarker] = array[rightMarker];

                    array[rightMarker] = item;

                    leftMarker++;
                    rightMarker--;
                }

            }

            array[right] = array[leftMarker];

            array[leftMarker] = pivot;

            pivotIndex = leftMarker;

            return array;
        }

        private static int GetPivotIndex(int[] array, int left, int right)
        {

            Random random = new Random();

            int index = random.Next(left + 1, right);

            return index;

        }

        public static int[] MergeSort(int[] array, int left, int right)
        {

            if(left < right)
            {

                if((right - left) <= 15)
                {

                    for(int i = left + 1; i < right + 1; i++)
                    {

                        int j = i;
                        int t = array[j];

                        while(j > left && t < array[j - 1])
                        {
                            array[j] = array[j - 1];
                            j--;
                        }

                        array[j] = t;

                    }

                }
                else
                {

                    int mid = (left + right) / 2;

                    array = MergeSort(array, left, mid);
                    array = MergeSort(array, mid + 1, right);

                    array = Merge(array, left, mid, right);

                }

            }

            return array;

        }

        private static int[] Merge(int[] array, int left, int mid, int right)
        {

            int[] sortedArray = new int[right - left + 1];

            int arrayCount = 0;
            int leftCount = left;
            int rightCount = mid + 1;

            while(leftCount <= mid && rightCount <= right)
            {

                if(array[leftCount] <= array[rightCount])
                {
                    sortedArray[arrayCount] = array[leftCount];

                    leftCount++;
                }
                else
                {
                    sortedArray[arrayCount] = array[rightCount];

                    rightCount++;
                }

                arrayCount++;
            }

            if(leftCount > mid)
            {
                while(rightCount <= right)
                {
                    sortedArray[arrayCount] = array[rightCount];

                    rightCount++;
                    arrayCount++;
                }
            }
            else
            {
                while(leftCount <= mid)
                {
                    sortedArray[arrayCount] = array[leftCount];

                    leftCount++;
                    arrayCount++;
                }
            }

            for(int i = 0; i < sortedArray.Length; i++)
            {
                array[left + i] = sortedArray[i];
            }

            return array;

        }

    }
}
