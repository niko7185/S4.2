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

            if(node == null)
                return tree.Root.Value.value;

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

        public void Delete(TKey key)
        {

            int height = tree.GetHeight(tree.Root);

            var last = GetLast(height, tree.Root);

            RemoveNode(key, last.Value, tree.Root);

        }

        private bool RemoveNode(TKey key, (TKey key, TValue value) bucket, BinaryTreeNode<(TKey key, TValue value)> root)
        {

            bool done = false;

            if(root != null)
            {

                if(root.Value.key.CompareTo(key) == 0)
                {

                    root.Value = bucket;
                    done = true;
                }
                else
                {

                    done = RemoveNode(key, bucket, root.LeftChild);

                    if(!done)
                        done = RemoveNode(key, bucket, root.RightChild);

                }

            }

            return done;
        }

        private BinaryTreeNode<(TKey key, TValue value)> GetLast(int level, BinaryTreeNode<(TKey key, TValue value)> root)
        {

            if(level <= 1)
            {

                return root;
            }

            BinaryTreeNode<(TKey key, TValue value)> node = null;

            if(root.LeftChild != null)
            {
                node = GetLast(level - 1, root.LeftChild);

                if(node != null && level <= 2)
                    root.RemoveLeftChild();

            }

            if(root.RightChild != null && node == null)
            {
                node = GetLast(level - 1, root.RightChild);

                if(node != null && level <= 2)
                    root.RemoveRightChild();
            }

            return node;
        }

    }
}
