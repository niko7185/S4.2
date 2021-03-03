using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class Node<T>
    {
        private Node<T> next;

        public Node<T> Next => next;
        public T Value { get; set; }

        public Node(T value)
        {
            Value = value;
        }

        public Node(T value, Node<T> next)
        {
            Value = value;

            this.next = next;
        }

    }
}
