using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BinarySearchTree<T>: BinaryTree<T> where T : IComparable<T>
    {
        public BinarySearchTree(BinaryTreeNode<T> root) : base(root)
        {
        }

        
        public void Insert(T item)
        {

            if(root == null)
                root = new BinaryTreeNode<T>(item);
            else
                root.Insert(item);
        }

        public void InsertMany(LinearDataStructure<T> dataStructure)
        {

            T[] items = dataStructure.ToArray();

            if(items != null)
            {

                int i = 0;

                if(root == null)
                {

                    root = new BinaryTreeNode<T>(items[0]);
                    i = 1;
                }

                for(; i < dataStructure.Count; i++)
                {
                    root.Insert(items[i]);
                }

            }

        }

    }
}
