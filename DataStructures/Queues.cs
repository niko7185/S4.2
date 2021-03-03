using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Queues<T>: LinearDataStructure<T>
    {
        public Queues() : base(5) { }

        public Queues(T[] createdArray) : base(createdArray.Length)
        {
            array = createdArray;

            count = createdArray.Length;

            ResizeTo(length * 2);
        }

        public void Push(T item)
        {

            Insert(item);

        }

        public T Pop()
        {
            T item = array[0];

            Remove(0);
            return item;
        }

        public T Peek()
        {
            return array[0];
        }

        public void Reverse()
        {

            T[] reversedArray = new T[array.Length];

            int itemNum = Count - 1;

            for(int i = 0; i < length; i++)
            {
                if(itemNum < 0)
                {
                    break;
                }

                reversedArray[i] = array[itemNum];

                itemNum--;

            }

            array = reversedArray;

        }

        public override object Clone()
        {

            T[] cloneArray = new T[count];

            for(int i = 0; i < count; i++)
            {
                cloneArray[i] = array[i];
            }

            Queue<T> queue = new Queue<T>(cloneArray);

            return queue;
        }

    }
}
