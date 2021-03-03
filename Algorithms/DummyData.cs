using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms
{
    public static class DummyData <T>
    {

        public static T[] CreateArray(int length, T[] values)
        {
            T[] array = new T[length];
            int index = 0;

            for(int i = 0; i < length; i++)
            {
                array[i] = values[index];

                index++;

                if(index >= values.Length)
                    index = 0;
            }

            return array;
        }

        public static T[] CreateReverseArray(int length, T[] values)
        {
            T[] array = new T[length];
            int index = values.Length - 1;

            for(int i = 0; i < length; i++)
            {
                array[i] = values[index];

                index--;

                if(index < 0)
                    index = values.Length - 1;
            }

            return array;
        }

        public static List<T> CreateList(int length, List<T> values)
        {
            List<T> list = new List<T>();
            int index = 0;

            for(int i = 0; i < length; i++)
            {
                list.Add(values[index]);

                index++;

                if(index >= values.Count)
                    index = 0;
            }

            return list;
        }

    }
}
