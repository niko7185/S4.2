using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class AVLTree<T>: BinaryTree<T> where T : IComparable<T>
    {
        public AVLTree(BinaryTreeNode<T> root) : base(root) { }

        public void Insert(T item)
        {

            if(item == null)
                return;

            root.Insert(item, out BinaryTreeNode<T> node);

            if(node != null)
                Rebalance(node);

        }

        private void Rebalance(BinaryTreeNode<T> node)
        {

            var parent = node.Parent as BinaryTreeNode<T>;

            int leftHeight = GetHeight(node.LeftChild);
            int rightHeight = GetHeight(node.RightChild);

            if(leftHeight > rightHeight + 1)
                RightRebalance(node);

            if(rightHeight > leftHeight + 1)
                LeftRebalance(node);

            if(parent != null)
                Rebalance(parent);

        }

        private void RightRebalance(BinaryTreeNode<T> node)
        {
            int leftHeight = GetHeight(node.LeftChild.LeftChild);
            int rightHeight = GetHeight(node.LeftChild.RightChild);

            if(rightHeight > leftHeight)
                RotateLeft(node.LeftChild);

            RotateRight(node);

        }

        private void LeftRebalance(BinaryTreeNode<T> node)
        {
            int leftHeight = GetHeight(node.RightChild.LeftChild);
            int rightHeight = GetHeight(node.RightChild.RightChild);

            if(rightHeight < leftHeight)
                RotateRight(node.RightChild);

            RotateLeft(node);

        }

        private void RotateLeft(BinaryTreeNode<T> node)
        {

            BinaryTreeNode<T> rotatedRoot = new BinaryTreeNode<T>(node.Value);

            rotatedRoot.AddLeftChild(node.LeftChild);

            rotatedRoot.AddRightChild(node.RightChild.LeftChild);

            node.Value = node.RightChild.Value;


            node.AddRightChild(node.RightChild.RightChild);

            node.AddLeftChild(rotatedRoot);


        }

        private void RotateRight(BinaryTreeNode<T> node)
        {

            BinaryTreeNode<T> rotatedRoot = new BinaryTreeNode<T>(node.Value);

            rotatedRoot.AddRightChild(node.RightChild);

            rotatedRoot.AddLeftChild(node.LeftChild.RightChild);

            node.Value = node.LeftChild.Value;


            node.AddLeftChild(node.LeftChild.LeftChild);

            node.AddRightChild(rotatedRoot);

        }

    }
}
