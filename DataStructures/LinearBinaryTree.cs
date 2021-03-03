using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinearBinaryTree<T>: LinearDataStructure<T> where T : IComparable<T>
    {

        public LinearBinaryTree(T root) : base(5) { Insert(root); }

        public LinearBinaryTree(T[] createdArray) : base(createdArray.Length)
        {
            array = createdArray;

            count = createdArray.Length;
            ResizeTo(length * 2);
        }

        public T GetValue(int nodeIndex) { return array[nodeIndex]; }

        public T GetParent(int nodeIndex)
        {

            int parentIndex = (nodeIndex / 2) - (1 - (nodeIndex % 2));

            if(parentIndex < 0)
                return array[0];

            return array[parentIndex];

        }

        public T GetLeftChild(int nodeIndex)
        {

            int leftChildIndex = 2 * nodeIndex + 1;

            if(leftChildIndex >= array.Length)
                return array[0];

            return array[leftChildIndex];

        }

        public T GetRightChild(int nodeIndex)
        {

            int rightChildIndex = 2 * nodeIndex + 2;

            if(rightChildIndex >= array.Length)
                return array[0];

            return array[rightChildIndex];

        }

        public void InsertLeftChild(int nodeIndex, T value)
        {

            if(array[nodeIndex] == null)
                return;

            int leftChildIndex = 2 * nodeIndex + 1;

            if(leftChildIndex >= array.Length)
                ResizeTo(leftChildIndex + 2);

            array[leftChildIndex] = value;
            count++;

        }

        public void InsertRightChild(int nodeIndex, T value)
        {

            if(array[nodeIndex] == null)
                return;

            int rightChildIndex = 2 * nodeIndex + 2;

            if(rightChildIndex >= array.Length)
                ResizeTo(rightChildIndex + 2);

            array[rightChildIndex] = value;
            count++;

        }

        public void SearchInsert(int nodeIndex, T value)
        {

            if(array[nodeIndex].CompareTo(value) >= 0)
            {
                int leftChildIndex = 2 * nodeIndex + 1;

                if(leftChildIndex >= array.Length)
                    ResizeTo(leftChildIndex + 2);

                if(array[leftChildIndex] == null)

                {

                    array[leftChildIndex] = value;
                    count++;
                }
                else
                    SearchInsert(leftChildIndex, value);

            }
            else
            {

                int rightChildIndex = 2 * nodeIndex + 2;

                if(rightChildIndex >= array.Length)
                    ResizeTo(rightChildIndex + 2);

                if(array[rightChildIndex] == null)
                {

                    array[rightChildIndex] = value;
                    count++;
                }
                else
                    SearchInsert(rightChildIndex, value);
            }

        }

        public int Search(T value)
        {
            return SearchIndex(value, 0);
        }

        private int SearchIndex(T value, int nodeIndex)
        {

            int index = -1;

            if(nodeIndex <= array.Length && array[nodeIndex] != null)
            {

                if(array[nodeIndex].CompareTo(value) == 0)
                {

                    return nodeIndex;
                }
                int leftChildIndex = 2 * nodeIndex + 1;

                index = SearchIndex(value, leftChildIndex);

                if(index >= 0)
                    return index;

                int rightChildIndex = 2 * nodeIndex + 2;

                index = SearchIndex(value, rightChildIndex);
            }

            return index;

        }

    }
}
