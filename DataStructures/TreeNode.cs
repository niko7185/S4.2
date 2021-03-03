using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class TreeNode<T>: Node<T>
    {
        private TreeNode<T> parent;

        public TreeNode<T> Parent => parent;

        public TreeNode(T value) : base(value) { }

        public TreeNode(T value, TreeNode<T> parent) : base(value)
        {

            this.parent = parent;
        }



    }
}
