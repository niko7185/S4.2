using System;
using System.Text;

namespace DataStructures
{
    public interface IHeap<T> where T : IComparable<T>
    {

        void Insert(T item);
        T Extract();
        List<T> Search(int level, BinaryTreeNode<T> root);
        T Search(int level, int node, BinaryTreeNode<T> root);
        void Delete(T item);

    }
}
