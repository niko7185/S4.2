using System;
using System.Text;

namespace DataStructures
{
    public class MaxHeap<T>: BinaryTree<T>, IHeap<T> where T : IComparable<T>
    {
        public MaxHeap(BinaryTreeNode<T> root) : base(root)
        {
        }

        public void Delete(T item)
        {

            DeleteNode(item, Root);
        }

        private bool DeleteNode(T item, BinaryTreeNode<T> root)
        {

            if(item == null || root == null)
                return false;

            if(item.CompareTo(root.Value) == 0)
            {

                if(!root.isEmpty)
                {

                    GetLast(Root, GetHeight(Root), out T last);

                    if(last.CompareTo(root.Value) >= 0)
                    {
                        root.Value = last;

                        UpHeapify(root);
                    }
                    else
                    {

                        root.Value = last;

                        DownHeapify(root);
                    }

                }

                return true;
            }

            bool done = DeleteNode(item, root.LeftChild);

            if(done && root.LeftChild.isEmpty)
                root.RemoveLeftChild();

            if(!done)
            {

                done = DeleteNode(item, root.RightChild);

                if(done && root.RightChild.isEmpty)
                    root.RemoveRightChild();
            }

            return done;
        }

        private bool GetLast(BinaryTreeNode<T> root, int height, out T value)
        {
            value = root.Value;

            if(height == 1)
            {

                return true;
            }

            if(root.LeftChild == null && root.RightChild == null)
            {
                return false;
            }

            bool done = false;

            if(!done && root.LeftChild != null)
            {
                done = GetLast(root.LeftChild, height - 1, out T newValue);

                if(done)
                {
                    value = newValue;

                    if(height == 2)
                        root.RemoveLeftChild();

                    return true;
                }
            }

            if(!done && root.RightChild != null)
            {
                done = GetLast(root.RightChild, height - 1, out T newValue);

                if(done)
                {
                    value = newValue;

                    if(height == 2)
                        root.RemoveRightChild();

                    return true;
                }
            }

            return done;
        }

        private void UpHeapify(TreeNode<T> node)
        {

            if(node.Parent == null)
                return;

            if(node.Value.CompareTo(node.Parent.Value) >= 0)
            {
                T value = node.Value;

                node.Value = node.Parent.Value;

                node.Parent.Value = value;
            }

            UpHeapify(node.Parent);
        }

        private void DownHeapify(BinaryTreeNode<T> node)
        {

            if(node == null)
                return;

            if(node.Parent != null)
            {
                if(node.Value.CompareTo(node.Parent.Value) >= 0)
                {
                    T value = node.Value;

                    node.Value = node.Parent.Value;

                    node.Parent.Value = value;
                }
            }

            DownHeapify(node.LeftChild);
            DownHeapify(node.RightChild);
        }

        public T Extract()
        {

            T value = Root.Value;

            GetLast(Root, GetHeight(Root), out T last);

            root.Value = last;

            DownHeapify(Root);

            return value;

        }

        public void Insert(T item)
        {
            int level = GetMinHeight(Root);

            InsertItem(item, level, Root);
        }

        private bool InsertItem(T item, int level, BinaryTreeNode<T> root)
        {

            if(root == null || level < 1)
            {
                return false;
            }

            if(level <= 2)
            {

                if(root.LeftChild == null)
                {
                    root.AddLeftChild(item); 
                    UpHeapify(root.LeftChild);
                    return true;
                }
                else if(root.RightChild == null)
                {

                    root.AddRightChild(item);
                    UpHeapify(root.RightChild);
                    return true;
                }
            }

            bool inserted = false;

            inserted = InsertItem(item, level - 1, root.LeftChild);

            if(!inserted)
                inserted = InsertItem(item, level - 1, root.RightChild);

            return inserted;
        }

        public List<T> Search(int level, BinaryTreeNode<T> root)
        {
            List<T> list = new List<T>();

            if(level == 1)
            {

                list.InsertItem(root.Value);

                return list;
            }

            if(root.LeftChild != null)
                list = Search(level - 1, root.LeftChild);

            if(root.RightChild != null)
            {
                if(list.isNull)
                    list = Search(level - 1, root.RightChild);
                else
                    list.InsertMany(Search(level - 1, root.RightChild));
            }

            return list;
        }

        public T Search(int level, int node, BinaryTreeNode<T> root)
        {

            List<T> nodes = Search(level, root);

            return nodes.GetItem(node);
            
        }
    }
}
