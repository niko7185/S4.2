using System;
using System.Text;

namespace DataStructures
{
    public class MAryTreeNode<T>: TreeNode<T>
    {

        protected List<MAryTreeNode<T>> children;

        public int Length => children.Count;

        public MAryTreeNode(T value) : base(value) { children = new List<MAryTreeNode<T>>(); }
        public MAryTreeNode(T value, MAryTreeNode<T> parent) : base(value, parent) { children = new List<MAryTreeNode<T>>(); }

        public MAryTreeNode<T> Node(int index) => children.GetItem(index);

        public void AddChildNode(T value)
        {
            MAryTreeNode<T> node = new MAryTreeNode<T>(value, this);

            children.InsertItem(node);
        }

    }
}
