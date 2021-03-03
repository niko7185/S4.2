using System;
using System.Text;

namespace DataStructures
{
    public class BucketTreeEntry<TKey, TValue>: BucketEntry<TKey, TValue> where TKey : IComparable<TKey>
    {

        private BinarySearchTree<(TKey key, TValue value)> tree;


        public BinarySearchTree<(TKey key, TValue value)> Tree => tree;

        public override TValue Head => tree.Root.Value.value;


        public BucketTreeEntry(TKey key, TValue value)
        {
            tree = new BinarySearchTree<(TKey key, TValue value)>(new BinaryTreeNode<(TKey key, TValue value)>((key, value)));
        }

        public override void Add(TKey key, TValue value)
        {

            if(tree == null)
            {
                tree = new BinarySearchTree<(TKey key, TValue value)>(new BinaryTreeNode<(TKey key, TValue value)>((key, value)));
            }
            else
            {
                tree.Insert((key, value));
            }

        }

        public TValue Find(TKey key)
        {

            BinaryTreeNode<(TKey key, TValue value)> node = Search(key, tree.Root);

            return node.Value.value;
        }

        private BinaryTreeNode<(TKey key, TValue value)> Search(TKey key, BinaryTreeNode<(TKey key, TValue value)> root)
        {

            BinaryTreeNode<(TKey key, TValue value)> node = null;

            if(root != null)
            {

                if(root.Value.key.CompareTo(key) == 0)
                {

                    return root;
                }

                node = Search(key, root.LeftChild);

                if(node != null)
                    return node;

                node = Search(key, root.RightChild);
            }

            return node;
        }

    }
}
