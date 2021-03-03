using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BinaryTree<T>: IBinaryTree<T> where T : IComparable<T>
    {

        protected int count;
        protected BinaryTreeNode<T> root;

        public BinaryTreeNode<T> Root => root;
        public int Count => count;

        public BinaryTree(BinaryTreeNode<T> root)
        {
            this.root = root;
        }


        public void AddLeftChildTo(BinaryTreeNode<T> parent, T leftChildItem)
        {
            parent.AddLeftChild(leftChildItem);
        }

        public void AddRightChildTo(BinaryTreeNode<T> parent, T rightChildItem)
        {
            parent.AddRightChild(rightChildItem);
        }

        public int GetHeight(BinaryTreeNode<T> root)
        {
            if(root == null)
                return 0;

            int leftHeight = GetHeight(root.LeftChild);
            int rightHeight = GetHeight(root.RightChild);

            return Math.Max(leftHeight, rightHeight) + 1;

        }


        public int GetMinHeight(BinaryTreeNode<T> root)
        {
            if(root == null)
                return 0;

            int leftHeight = GetMinHeight(root.LeftChild);
            int rightHeight = GetMinHeight(root.RightChild);

            return Math.Min(leftHeight, rightHeight) + 1;

        }

        public int GetCount()
        {
            count = NodeCount(Root);

            return count;
        }

        private int NodeCount(BinaryTreeNode<T> node)
        {
            if(node.isEmpty)
            {
                return 1;
            }

            int leftCount = node.LeftChild == null ? 0 : NodeCount(node.LeftChild);
            int rightCount = node.RightChild == null ? 0 : NodeCount(node.RightChild);

            return leftCount + rightCount + 1;
        }

        public string ToStringLevel(int level, BinaryTreeNode<T> root)
        {

            if(root == null)
                return "";

            if(level <= 1)
            {
                return $"({root.Value} | {(root.Parent == null ? "/" : root.Parent.Value.ToString())})";
            }

            return ToStringLevel(level - 1, root.LeftChild) + ToStringLevel(level - 1, root.RightChild);

        }

        public string ToStringLevelOrder()
        {

            int height = GetHeight(Root);

            string result = "";

            for(int i = 1; i <= height; i++)
            {
                result += ToStringLevel(i, Root);
            }

            return result;
        }

        public string PreOrder(int level, BinaryTreeNode<T> root)
        {

            if(root != null)
            {

                if(level <= 1)
                {
                    return $"({root.Value} | {(root.Parent == null ? "/" : root.Parent.Value.ToString())})";
                }

                string result = PreOrder(level - 1, root.LeftChild);

                result += PreOrder(level - 1, root.RightChild);

                return result;
            }

            return "";
        }

        public string InOrder(int level, BinaryTreeNode<T> root)
        {

            if(root != null && level >= 1)
            {

                string result = InOrder(level - 1, root.LeftChild);

                if(level == 1)
                {
                    return $"({root.Value} | {(root.Parent == null ? "/" : root.Parent.Value.ToString())})";
                }

                result += InOrder(level - 1, root.RightChild);

                return result;
            }

            return "";
        }

        public string PostOrder(int level, BinaryTreeNode<T> root)
        {

            if(root != null && level >= 1)
            {

                string result =PostOrder(level - 1, root.LeftChild);

                result += PostOrder(level - 1, root.RightChild);

                if(level == 1)
                {
                    return $"({root.Value} | {(root.Parent == null ? "/" : root.Parent.Value.ToString())})";
                }

                return result;
            }

            return "";
        }

        public BinaryTreeNode<T> BinarySearch(T value, BinaryTreeNode<T> root)
        {

            BinaryTreeNode<T> node = null;

            if(root != null)
            {

                if(root.Value.CompareTo(value) == 0)
                {

                    return root;
                }

                node = BinarySearch(value, root.LeftChild);

                if(node != null)
                    return node;

                node = BinarySearch(value, root.RightChild);
            }

            return node;
        }

    }
}
