using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class List<T>: LinearDataStructure<T>
    {

        public int Length => array.Length;

        public List() : base(5){ }

        public List(T[] createdArray) : base(createdArray.Length)
        {
            array = createdArray;

            count = createdArray.Length;
            ResizeTo(length * 2);
        }

        public T GetItem(int index)
        {
            if(index < Count)
            {
                return array[index];
            }

            return array[0];
        }

        public void InsertItem(T item)
        {
            Insert(item);
        }

        public void UpdateItem(T item, int index)
        {
            Update(item, index);
        }

        public void RemoveItem(int index)
        {
            Remove(index);
        }

        public override object Clone()
        {

            T[] cloneArray = new T[count];

            for(int i = 0; i < count; i++)
            {
                cloneArray[i] = array[i];
            }

            List<T> list = new List<T>(cloneArray);

            return list;
        }

        public void InsertMany(List<T> items)
        {

            for(int i = 0; i < items.Count; i++)
            {
                Insert(items.GetItem(i));
            }

        }

    }
}
