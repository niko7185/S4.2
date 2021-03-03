using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class LinkedList<T>: LinearDataStructure<Node<T>>
    {
        public LinkedList() : base(5) { }

        public LinkedList(Node<T>[] createdArray) : base(createdArray.Length)
        {
            array = createdArray;

            count = createdArray.Length;

            ResizeTo(length * 2);
        }

        public void Add(T item)
        {

            Node<T> node = new Node<T>(item, array[0]);

            Insert(node);

            for(int i = Count - 1; i > 0; i--)
            {
                array[i] = array[i - 1];
            }

            array[0] = node;

        }

        public void Remove()
        {

            Remove(0);
        }

        public Node<T> First()
        {
            return array[0];
        }

        public override object Clone()
        {

            Node<T>[] cloneArray = new Node<T>[count];

            for(int i = 0; i < count; i++)
            {
                cloneArray[i] = array[i];
            }

            LinkedList<T> linkedList = new LinkedList<T>(cloneArray);

            return linkedList;
        }

    }
}
