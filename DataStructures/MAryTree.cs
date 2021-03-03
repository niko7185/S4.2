using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures
{
    public class MAryTree<T>: IMAryTree<T>
    {
        protected int count;
        protected MAryTreeNode<T> root;

        public MAryTreeNode<T> Root => root;

        public int Count => count;

        public MAryTree(T value)
        {
            root = new MAryTreeNode<T>(value);
        }


        public int GetHeight(MAryTreeNode<T> root)
        {
            throw new NotImplementedException();
        }

        public string ToStringLevel(int level, MAryTreeNode<T> root)
        {

            string result = "";

            if(root == null)
                return result;

            if(level <= 1)
            {
                return $"({root.Value} | {(root.Parent == null ? "/" : root.Parent.Value.ToString())})";
            }
            else
            {

                for(int i = 0; i < root.Length; i++)
                {
                    result += ToStringLevel(level - 1, root.Node(i));
                }

            }

            return result;
        }

        public string ToStringLevelOrder()
        {
            int height = GetHeight(Root);

            string result = "";

            for(int i = 1; i <= height; i++)
            {
                result += ToStringLevel(i, Root) + "\n";
            }

            return result;
        }
    }
}
