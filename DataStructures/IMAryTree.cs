using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public interface IMAryTree<T> : INonLinearDataStructure<T>
    {
        abstract MAryTreeNode<T> Root { get; }

        int GetHeight(MAryTreeNode<T> root);
        string ToStringLevel(int level, MAryTreeNode<T> root);
        string ToStringLevelOrder();

    }
}
