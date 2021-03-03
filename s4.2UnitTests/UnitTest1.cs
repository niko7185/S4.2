
using Algorithms;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

using Xunit;

namespace s4._2UnitTests
{
    public class UnitTest1
    {

        [Fact]
        public void Test1()
        {
            List<Exception> exceptions = Recursion.GetExceptions(
                new Exception("eagega", new Exception("236jf", new Exception("k459hj9")))).ToList();

            Assert.True(exceptions.Count == 3 && exceptions[0].Message == "k459hj9");

        }

        [Fact]
        public void TestFindNumber()
        {

            int[] nonSortedArray = DummyData<int>.CreateArray(100000, new int[] { 1, 2, 3, 4, 5, 6, 7 });

            int[] sortedArray = new int[100000];

            for(int i = 0; i < sortedArray.Length; i++)
            {
                sortedArray[i] = i + 1;
            }

            //Stopwatch watch = Stopwatch.StartNew();
            //
            //bool sorted = SearchAlgorithms.NumericlySorted(sortedArray);
            //
            //watch.Stop();

            Stopwatch watch = Stopwatch.StartNew();

            int index = SearchAlgorithms.FindNumber(sortedArray, 139);

            watch.Stop();

            //Assert.Equal(0, watch.ElapsedTicks);
            //
            //Assert.True(sorted);

            //Assert.Equal(0, watch.ElapsedTicks);

            Assert.True(sortedArray[index] == 139);

        }

        [Fact]
        public void TestForDuplicates()
        {

            int[] sortedArray = new int[10]
            {
                1, 2, 3, 4, 5, 6, 6, 6, 9, 10
            };

            int index = SearchAlgorithms.FindNumber(sortedArray, 6);

            Assert.Equal(7, index);

        }

        [Fact]
        public void TestBubbleSorting()
        {

            int[] sortedArray = new int[10]
            {
                -1, 2, 3, 6, -5, 6, 4, -6, 9, 6
            };

            int[] array = DummyData<int>.CreateReverseArray(10000, sortedArray);

            array = Sorting.BubbleSort(array);

            bool isSorted = SearchAlgorithms.NumericlySorted(array);

            Assert.True(isSorted);

        }

        [Fact]
        public void TestInsertionSorting()
        {

            int[] sortedArray = new int[10]
            {
                -1, 2, 3, 6, -5, 6, 4, -6, 9, 6
            };

            int[] array = DummyData<int>.CreateReverseArray(10000, sortedArray);

            array = Sorting.InsertionSort(array);

            bool isSorted = SearchAlgorithms.NumericlySorted(array);

            Assert.True(isSorted);

        }

        [Fact]
        public void TestSelectionSorting()
        {

            int[] sortedArray = new int[10]
            {
                -1, 2, 3, 6, -5, 6, 4, -6, 9, 6
            };

            int[] array = DummyData<int>.CreateReverseArray(10000, sortedArray);

            array = Sorting.SelectionSort(array);

            bool isSorted = SearchAlgorithms.NumericlySorted(array);

            Assert.True(isSorted);

        }

        [Fact]
        public void TestQuickSorting()
        {

            int[] sortedArray = new int[10]
            {
                -1, 2, 3, 6, -5, 6, 4, -6, 9, 6
            };

            int[] array = DummyData<int>.CreateReverseArray(10000, sortedArray);

            array = Sorting.QuickSort(array, 0, array.Length - 1);

            bool isSorted = SearchAlgorithms.NumericlySorted(array);

            Assert.True(isSorted);

        }

        [Fact]
        public void TestMergeSorting()
        {

            int[] sortedArray = new int[10]
            {
                -1, 2, 3, 6, -5, 6, 4, -6, 9, 6
            };

            int[] array = DummyData<int>.CreateReverseArray(10000, sortedArray);

            array = Sorting.MergeSort(array, 0, array.Length - 1);

            bool isSorted = SearchAlgorithms.NumericlySorted(array);

            Assert.True(isSorted);

        }

    }
}
