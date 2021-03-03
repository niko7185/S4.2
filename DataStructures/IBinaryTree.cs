using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public interface IBinaryTree<T> : INonLinearDataStructure<T> where T : IComparable<T>
    {

        abstract BinaryTreeNode<T> Root { get; }

        int GetHeight(BinaryTreeNode<T> root);
        string ToStringLevel(int level, BinaryTreeNode<T> root);
        string ToStringLevelOrder();
        void AddLeftChildTo(BinaryTreeNode<T> parent, T leftChildItem);
        void AddRightChildTo(BinaryTreeNode<T> parent, T rightChildItem);

    }
}
