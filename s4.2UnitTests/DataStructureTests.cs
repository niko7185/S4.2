using DataStructures;

using System;
using System.Text;

using Xunit;

namespace s4._2UnitTests
{
    public class DataStructureTests
    {

        [Fact]
        public void TestGenericList()
        {

            List<int> list = new List<int>();

            if(list.Count != 0)
                Assert.True(false);

            list.InsertItem(4);

            if(list.GetItem(0) != 4 && list.Count == 1)
                Assert.True(false);

            list = new List<int>(new int[] { 1, 2, 3, 4, 5 });

            if(list.Length != 10)
                Assert.True(false);

            if(list.Count != 5)
                Assert.True(false);

            list.InsertItem(6);

            if(list.Length != 10)
                Assert.True(false);

            list.RemoveItem(2);
            list.RemoveItem(3);

            if(list.Length != 5)
                Assert.True(false);

            if(list.GetItem(2) != 4)
                Assert.True(false);

        }

        [Fact]
        public void TestStack()
        {

            Stack<string> stack = new Stack<string>(new string[] { "asg", "hrh", "hy45h", "54", "hjuy" });

            if(stack.Count != 5)
                Assert.Equal(5, stack.Count);

            if(stack.Peek() != "asg")
                Assert.True(false);

            stack.Push("obgiorg");

            if(stack.Peek() != "obgiorg")
                Assert.True(false);

            stack.Pop();

            if(stack.Peek() != "asg")
                Assert.True(false);

        }

        [Fact]
        public void TestQueues()
        {

            Queues<string> queue = new Queues<string>(new string[] { "asg", "hrh", "hy45h", "54", "hjuy" });

            if(queue.Count != 5)
                Assert.Equal(5, queue.Count);

            if(queue.Peek() != "asg")
                Assert.True(false);

            queue.Push("obgiorg");

            if(queue.Peek() != "asg")
                Assert.True(false);

            queue.Pop();

            if(queue.Peek() != "hrh")
                Assert.True(false);

        }

        [Fact]
        public void TestLinkedList()
        {

            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.Add("geag");

            if(linkedList.Count != 1)
                Assert.True(false);

            if(linkedList.First().Next != null)
                Assert.True(false);

            if(linkedList.First().Value != "geag")
                Assert.True(false);

            linkedList.Add("obgiorg");

            if(linkedList.First().Next.Value != "geag")
                Assert.True(false);

            if(linkedList.First().Value != "obgiorg")
                Assert.True(false);

            linkedList.Remove();

            if(linkedList.First().Value != "geag")
                Assert.True(false);

            if(linkedList.First().Next != null)
                Assert.True(false);

        }

        [Fact]
        public void TestStackQueue()
        {

            Queues<Stack<string>> stackQueue = new Queues<Stack<string>>();

            Stack<string> stackOne = new Stack<string>(new string[] { "aefega", "ijjiriu" });
            Stack<string> stackTwo = new Stack<string>(new string[] { "ngmvnm", "48gdhjg" });

            stackQueue.Push(stackOne);
            stackQueue.Push(stackTwo);

            stackQueue.Peek().Push("------");

            if(stackQueue.Peek().Peek() != "------")
                Assert.True(false);

        }

        [Fact]
        public void TestBinaryTree()
        {

            BinaryTree<string> binaryTree = new BinaryTree<string>(new BinaryTreeNode<string>("The root"));

            if(!binaryTree.Root.isEmpty)
                Assert.True(false);

            if(binaryTree.Root.Value != "The root")
                Assert.True(false);

            binaryTree.Root.AddRightChild("right node");

            if(binaryTree.Root.Value != binaryTree.Root.RightChild.Parent.Value)
                Assert.True(false);

            if(binaryTree.Root.RightChild.Value != "right node")
                Assert.True(false);

            binaryTree.Root.RightChild.AddRightChild("right node right child");

            binaryTree.Root.RightChild.AddLeftChild("right node left child");

            binaryTree.Root.RightChild.LeftChild.AddLeftChild("right node leaf");

            binaryTree.Root.AddLeftChild("left node");

            if(binaryTree.GetHeight(binaryTree.Root) != 4)
                Assert.Equal(4, binaryTree.GetHeight(binaryTree.Root));

            if(binaryTree.GetMinHeight(binaryTree.Root) != 2)
                Assert.Equal(2, binaryTree.GetMinHeight(binaryTree.Root));

            if(binaryTree.GetCount() != 6)
                Assert.Equal(6, binaryTree.Count);

            Assert.Equal("(right node left child | right node)(right node right child | right node)", binaryTree.ToStringLevel(3, binaryTree.Root));

        }

        [Fact]
        public void TestBinarySearchTree()
        {

            BinarySearchTree<string> binaryTree = new BinarySearchTree<string>(new BinaryTreeNode<string>("R"));

            binaryTree.Insert("L");

            if(binaryTree.Root.LeftChild == null)
                Assert.True(false);

            binaryTree.Insert("Y");

            if(binaryTree.Root.RightChild == null)
                Assert.True(false);

            binaryTree.Insert("T");
            binaryTree.Insert("S");

            if(binaryTree.Root.RightChild.LeftChild.LeftChild.Value != "S")
                Assert.True(false);

            BinarySearchTree<int> secondBinaryTree = new BinarySearchTree<int>(new BinaryTreeNode<int>(100));

            Stack<int> stack = new Stack<int>(new int[] { 150, 25, 50, 125, 110, 105, 115 });

            secondBinaryTree.InsertMany(stack);


            if(secondBinaryTree.Root.RightChild.LeftChild.LeftChild.LeftChild.Value != 105)
                Assert.True(false);

        }

        [Fact]
        public void TestBinaryHeap()
        {

            MaxHeap<int> maxHeap = new MaxHeap<int>(new BinaryTreeNode<int>(100));

            maxHeap.Insert(80);
            maxHeap.Insert(85);
            maxHeap.Insert(24);
            maxHeap.Insert(56);
            maxHeap.Insert(45);
            maxHeap.Insert(115);
            maxHeap.Insert(95);

            if(maxHeap.Root.LeftChild.Value != 95)
                Assert.Equal(95, maxHeap.Root.LeftChild.Value);

            if(maxHeap.Root.RightChild.Value != 100)
                Assert.Equal(100, maxHeap.Root.RightChild.Value);

            if(maxHeap.Root.Value != 115)
                Assert.Equal(115, maxHeap.Root.Value);

            if(maxHeap.Root.RightChild.RightChild.Value != 85)
                Assert.Equal(85, maxHeap.Root.RightChild.RightChild.Value);

            if(maxHeap.Root.LeftChild.LeftChild.LeftChild.Value != 24)
                Assert.Equal(24, maxHeap.Root.LeftChild.LeftChild.LeftChild.Value);

            maxHeap.Delete(56);

            if(maxHeap.Root.LeftChild.RightChild.Value != 24)
                Assert.Equal(24, maxHeap.Root.LeftChild.RightChild.Value);

            if(maxHeap.Root.LeftChild.LeftChild.LeftChild != null)
                Assert.Equal(24, maxHeap.Root.LeftChild.LeftChild.LeftChild.Value);

        }

        [Fact]
        public void TestBinarySearch()
        {

            MaxHeap<int> maxHeap = new MaxHeap<int>(new BinaryTreeNode<int>(100));

            maxHeap.Insert(80);
            maxHeap.Insert(85);
            maxHeap.Insert(24);
            maxHeap.Insert(56);
            maxHeap.Insert(45);
            maxHeap.Insert(115);
            maxHeap.Insert(95);

            if(maxHeap.BinarySearch(85, maxHeap.Root).Parent.Value != 100)
                Assert.True(false);

            BinarySearchTree<int> searchTree = new BinarySearchTree<int>(new BinaryTreeNode<int>(100));

            searchTree.Insert(80);
            searchTree.Insert(85);
            searchTree.Insert(24);
            searchTree.Insert(56);
            searchTree.Insert(45);
            searchTree.Insert(115);
            searchTree.Insert(95);

            if(searchTree.BinarySearch(56, searchTree.Root).Parent.Value != 24)
                Assert.True(false);


            if(searchTree.BinarySearch(115, searchTree.Root).Parent.Value != 100)
                Assert.True(false);

        }

        [Fact]
        public void TestHashTable()
        {


            HashTable<string, int> hashTable = new HashTable<string, int>();

            for(int i = 1; i < 700; i++)
            {
                hashTable.Add(i.ToString(), i);

            }

            if(hashTable.LookUp("643") != 643)
                Assert.Equal(643, hashTable.LookUp("643"));

            if(hashTable.LookUp("56") != 56)
                Assert.Equal(56, hashTable.LookUp("56"));

            if(hashTable.LookUp("275") != 275)
                Assert.True(false);

            if(hashTable.LookUp("477") != 477)
                Assert.True(false);

            ChainableHashTable<string, int> chainableHashTable = new ChainableHashTable<string, int>();

            for(int i = 1; i < 1000; i++)
            {
                chainableHashTable.Add(i.ToString(), i);

            }

            if(hashTable.LookUp("643") != 643)
                Assert.Equal(643, hashTable.LookUp("643"));

            if(hashTable.LookUp("56") != 56)
                Assert.Equal(56, hashTable.LookUp("56"));

            if(hashTable.LookUp("275") != 275)
                Assert.True(false);

            if(hashTable.LookUp("477") != 477)
                Assert.True(false);
        }

    }
}
