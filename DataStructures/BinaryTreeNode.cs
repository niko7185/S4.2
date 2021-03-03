using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class BinaryTreeNode<T>: TreeNode<T> where T : IComparable<T>
    {

        private BinaryTreeNode<T> leftChild;
        private BinaryTreeNode<T> rightChild;

        public BinaryTreeNode<T> LeftChild => leftChild;
        public BinaryTreeNode<T> RightChild => rightChild;

        public bool isEmpty => leftChild == null && rightChild == null;


        public BinaryTreeNode(T value) : base(value) { }
        public BinaryTreeNode(T value, BinaryTreeNode<T> parent) : base(value, parent) { }

        public void AddLeftChild(T value)
        {
            BinaryTreeNode<T> treeNode = new BinaryTreeNode<T>(value, this);
            
            leftChild = treeNode;
        }

        public void AddRightChild(T value)
        {
            BinaryTreeNode<T> treeNode = new BinaryTreeNode<T>(value, this);

            rightChild = treeNode;
        }

        public void AddLeftChild(BinaryTreeNode<T> node)
        {

            if(node == null)
            {
                leftChild = null;
                return;
            }


            BinaryTreeNode<T> treeNode = new BinaryTreeNode<T>(node.Value, this);

            treeNode.AddLeftChild(node.LeftChild);

            treeNode.AddRightChild(node.RightChild);

            leftChild = treeNode;
        }

        public void AddRightChild(BinaryTreeNode<T> node)
        {

            if(node == null)
            {
                rightChild = null;
                return;
            }

            BinaryTreeNode<T> treeNode = new BinaryTreeNode<T>(node.Value, this);

            treeNode.AddLeftChild(node.LeftChild);

            treeNode.AddRightChild(node.RightChild);

            rightChild = treeNode;
        }

        public void RemoveLeftChild()
        {
            leftChild = null;
        }

        public void RemoveRightChild()
        {
            rightChild = null;
        }

        public void Insert(T item)
        {

            if(item.CompareTo(Value) < 0)
            {
                if(LeftChild == null)
                    AddLeftChild(item);
                else
                    LeftChild.Insert(item);
            }
            else
            {

                if(RightChild == null)
                    AddRightChild(item);
                else
                    RightChild.Insert(item);
            }

        }

        public void Insert(T item, out BinaryTreeNode<T> node)
        {
            node = null;

            if(item.CompareTo(Value) < 0)
            {
                if(LeftChild == null)
                {

                    AddLeftChild(item);
                    node = LeftChild;
                }
                else
                    LeftChild.Insert(item, out node);
            }
            else
            {

                if(RightChild == null)
                {

                    AddRightChild(item);
                    node = RightChild;
                }
                else
                    RightChild.Insert(item, out node);
            }

        }

    }
}
