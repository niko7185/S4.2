using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public abstract class LinearDataStructure<T> : ICloneable
    {

        protected T[] array;
        protected int length;
        protected int count;

        public int Count => count;
        public bool isNull => count == 0;

        protected LinearDataStructure(int initialLength)
        {
            array = new T[initialLength];
            length = initialLength;

            count = 0;
        }

        protected void Insert(T item)
        {
            array[count] = item;

            count++;

            if(count % length == 0)
            {
                ResizeTo(count + length);
            }
        }

        protected void Update(T item, int index)
        {
            if(index < count)
            {
                array[index] = item;
            }
        }

        protected void Remove(int index)
        {

            if(index < count)
            {

                for(int i = index; i < array.Length - 1; i++)
                {
                    array[i] = array[i + 1];
                }

                if(count % length == 0)
                {
                    ResizeTo(count);
                }

                count--;
                length = array.Length;
            }

        }

        protected void ResizeTo(int newLength)
        {

            T[] newArray = new T[newLength];

            for(int i = 0; i < newArray.Length; i++)
            {
                if(i >= array.Length)
                {
                    break;
                }

                newArray[i] = array[i];
            }

            array = newArray;
            length = newLength;

        }

        public virtual object Clone()
        {
            throw new NotImplementedException();
        }

        public T[] ToArray()
        {
            return array;
        }

    }
}
