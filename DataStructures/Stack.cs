using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Stack<T>: LinearDataStructure<T>
    {
        public Stack() : base(5) { }

        public Stack(T[] createdArray) : base(createdArray.Length)
        {
            array = createdArray;

            count = createdArray.Length;

            ResizeTo(length * 2);
        }

        public void Push(T item)
        {

            Insert(item);

            for(int i = Count - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = item;

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

        public override object Clone()
        {

            T[] cloneArray = new T[count];

            for(int i = 0; i < count; i++)
            {
                cloneArray[i] = array[i];
            }

            Stack<T> stack = new Stack<T>(cloneArray);

            return stack;
        }

    }
}
