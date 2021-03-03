using System;
//using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Timers;

using Algorithms;

using DataStructures;

namespace ConsoleLogger
{
    class Program
    {

        private static Queues<char> queue;
        private static Timer timer;

        static void Main(string[] args)
        {
            //MeasureSeachTime();

            //MeasureSortTime();

            //StackLog();

            //CharacterSequence();

            //LogPalindrome();

            //QueueLog();

            //LogLinkedList();

            //LogTreeDepthFirst();

            //LogSearchTree();

            //LogMaxHeap();

            //LogMinHeap();

            //LogAVLTree();

            //LogLinearTree();

            LogHashTable();

            //Console.WriteLine(Recursion.FibonacciSequence());
            //
            //Console.WriteLine(Recursion.FacultySequence(14));
            //Console.WriteLine(Recursion.FacultySequence(21));
            //
            //Console.WriteLine(Iteration.FibonacciSequence());
            //
            //Console.WriteLine(Iteration.FacultySequence(14));
            //Console.WriteLine(Iteration.FacultySequence(21));

            //int[] intValues = new int[] { 1, 2, 3, 4, 5 };
            //string[] stringValues = new string[] { "1", "2", "3", "4", "5" };
            //
            //for(int i = 10000; i <= 100000; i += 10000)
            //{
            //
            //    string[] longStringArray = DummyData<string>.CreateArray(i, stringValues);
            //
            //    Stopwatch watch = Stopwatch.StartNew();
            //
            //    bool contains = TimeComplexity.Contains(longStringArray, "500");
            //
            //    watch.Stop();
            //    
            //    Console.WriteLine($"N: {i} | Time: {watch.ElapsedTicks}\n");
            //
            //}

            //
            //int[] longIntArray = DummyData<int>.CreateArray(100000, intValues);
            //
            //string[] longStringArray = DummyData<string>.CreateArray(100000, stringValues);
            //
            //Stopwatch watch = Stopwatch.StartNew();
            //
            //int sum = TimeComplexity.Sum(longIntArray);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"Sum: {sum} | Time: {watch.ElapsedTicks}\n");
            //
            //watch = Stopwatch.StartNew();
            //
            //string find = TimeComplexity.Find(longStringArray, 500);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"Find: {find} | Time: {watch.ElapsedTicks}\n");
            //
            //watch = Stopwatch.StartNew();
            //
            //bool contains = TimeComplexity.Contains(longStringArray, "500");
            //
            //watch.Stop();
            //
            //Console.WriteLine($"Contains: {contains} | Time: {watch.ElapsedTicks}\n");
            //
            //watch = Stopwatch.StartNew();
            //
            //string[] removeAt = TimeComplexity.RemoveAt(longStringArray, 500);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"RemoveAt: Time: {watch.ElapsedTicks}\n");
            //
            //watch = Stopwatch.StartNew();
            //
            //string[] removeByValue = TimeComplexity.RemoveByValue(longStringArray, "500");
            //
            //watch.Stop();
            //
            //Console.WriteLine($"RemoveByValue: Time: {watch.ElapsedTicks}\n");
            //
            //string[] secondStringArray = DummyData<string>.CreateReverseArray(100000, stringValues);
            //
            //secondStringArray[24] = "56";
            //secondStringArray[666] = "346";
            //secondStringArray[32] = "96";
            //
            //watch = Stopwatch.StartNew();
            //
            //string[] matching = TimeComplexity.Matching(longStringArray, secondStringArray);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"Matching: Time: {watch.ElapsedTicks}\n");
            //
            //watch = Stopwatch.StartNew();
            //
            //var factorial = TimeComplexity.Factorial(80);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"Factorial: {factorial} | Time: {watch.ElapsedTicks}\n");
            //
            //watch = Stopwatch.StartNew();
            //
            //var sort = TimeComplexity.Sort(longIntArray);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"Sort: Time: {watch.ElapsedTicks}\n");
            //
            //int[] intArray = DummyData<int>.CreateArray(10, intValues);
            //
            //intArray[1] = 5;
            //intArray[8] = 3;
            //intArray[3] = -2;
            //
            //watch = Stopwatch.StartNew();
            //
            //Array.Sort(intArray);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"Sort 10: Time: {watch.ElapsedTicks}\n");
            //
            //intArray = DummyData<int>.CreateArray(100, intValues);
            //
            //intArray[1] = 5;
            //intArray[8] = 3;
            //intArray[3] = -2;
            //
            //watch = Stopwatch.StartNew();
            //
            //Array.Sort(intArray);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"Sort 100: Time: {watch.ElapsedTicks}\n");
            //
            //intArray = DummyData<int>.CreateArray(1000, intValues);
            //
            //intArray[1] = 5;
            //intArray[8] = 3;
            //intArray[3] = -2;
            //
            //watch = Stopwatch.StartNew();
            //
            //Array.Sort(intArray);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"Sort 1000: Time: {watch.ElapsedTicks}\n");
            //
            //intArray = DummyData<int>.CreateArray(10000, intValues);
            //
            //intArray[1] = 5;
            //intArray[8] = 3;
            //intArray[3] = -2;
            //
            //watch = Stopwatch.StartNew();
            //
            //Array.Sort(intArray);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"Sort 10000: Time: {watch.ElapsedTicks}\n");
            //
            //List<int> intList = DummyData<int>.CreateList(100000, intValues.ToList());
            //
            //watch = Stopwatch.StartNew();
            //
            //intList.Add(9);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"List.Add: Time: {watch.ElapsedTicks}\n");
            //
            //watch = Stopwatch.StartNew();
            //
            //intList.Contains(9);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"List.Contains: Time: {watch.ElapsedTicks}\n");
            //
            //watch = Stopwatch.StartNew();
            //
            //intList.Remove(9);
            //
            //watch.Stop();
            //
            //Console.WriteLine($"List.Remove: Time: {watch.ElapsedTicks}\n");
            //
            //watch = Stopwatch.StartNew();
            //
            //intList.Reverse();
            //
            //watch.Stop();
            //
            //Console.WriteLine($"List.Reverse: Time: {watch.ElapsedTicks}\n");
            //
            //watch = Stopwatch.StartNew();
            //
            //intList.Sort();
            //
            //watch.Stop();
            //
            //Console.WriteLine($"List.Sort: Time: {watch.ElapsedTicks}\n");


        }   

        private static void MeasureSeachTime()
        {

            bool worst = false;

            do
            {

                long min = worst ? 10000000 : 10;

                for(long i = min; i <= min * 10; i += min)
                {
                    long[] binaryTicks = new long[5];
                    long[] linearTicks = new long[binaryTicks.Length];

                    int[] array = new int[i];

                    for(int n = 0; n < i; n++)
                    {
                        array[n] = n + 1;
                    }

                    for(int runs = 0; runs < binaryTicks.Length; runs++)
                    {

                        Stopwatch watch = Stopwatch.StartNew();

                        SearchAlgorithms.FindNumber(array, i - 5);

                        watch.Stop();

                        binaryTicks[runs] = watch.Elapsed.Ticks;

                        watch = Stopwatch.StartNew();

                        SearchAlgorithms.LinearFindNumber(array, i - 5);

                        watch.Stop();

                        linearTicks[runs] = watch.Elapsed.Ticks;

                    }

                    Console.WriteLine($"Binary {i}: {binaryTicks.Average()}");
                    Console.WriteLine($"Linear {i}: {linearTicks.Average()}\n");

                }

                Console.WriteLine("");

                worst = !worst;

            } while(worst);
            

        }

        private static void MeasureSortTime()
        {

            for(long i = 10; i <= 1000000000; i *= 10)
            {

                int[] array = new int[i];

                for(int n = 0; n < i; n++)
                {
                    array[n] = (int)i - n;
                }

                Stopwatch watch = Stopwatch.StartNew();

                //Sorting.BubbleSort(array);
                //
                //watch.Stop();
                //
                //Console.WriteLine($"Bubble sort {i}: {watch.Elapsed.Ticks}");

                //watch = Stopwatch.StartNew();

                //Sorting.InsertionSort(array);
                //
                //watch.Stop();
                //
                //Console.WriteLine($"Insertion sort {i}: {watch.Elapsed.Ticks}");

                //watch = Stopwatch.StartNew();
                //
                //Sorting.SelectionSort(array);
                //
                //watch.Stop();
                //
                //Console.WriteLine($"Selection sort {i}: {watch.Elapsed.Ticks}");


                Sorting.QuickSort(array, 0, array.Length - 1);
                
                watch.Stop();
                
                Console.WriteLine($"QuickSort {i}: {watch.Elapsed.Ticks}");

                //Sorting.MergeSort(array, 0, array.Length - 1);
                //
                //watch.Stop();
                //
                //Console.WriteLine($"MergeSort {i}: {watch.Elapsed.Ticks}");

            }


        }

        public static void StackLog()
        {

            string firstChars = "EAS*Y*QUE***ST***IO*N***";
            string secondChars = "LA**STI*N*FIR*ST**OU*T******";

            string[] charArrays = new string[] { firstChars, secondChars };

            foreach(string chars in charArrays)
            {
                Stack<char> letters = new Stack<char>();

                string removed = "";
                string result = "";

                for(int i = 0; i < chars.Length; i++)
                {

                    if(chars[i] == '*')
                    {
                        if(letters.Count > 0)
                        {
                            removed += letters.Pop();
                        }
                    }
                    else
                    {
                        letters.Push(chars[i]);

                        result += letters.Peek();
                    }

                }
                Console.WriteLine($"Removed letters:\n{removed}\n");

                Console.WriteLine($"Stack length: ({letters.Count}):\n{result}\n");
            }

        }

        public static void CharacterSequence()
        {

            while(true)
            {

                Console.WriteLine("Enter character sequence to reverse:");

                string chars = Console.ReadLine();

                Stack<char> stack = new Stack<char>();

                for(int i = 0; i < chars.Length; i++)
                {
                    stack.Push(chars[i]);
                }

                for(int i = 0; i < chars.Length; i++)
                {
                    Console.Write(stack.Pop());
                }
                Console.WriteLine("\n\nContinue? y/n");
                char answer = Console.ReadKey(true).KeyChar;

                if(answer == 'n')
                {
                    break;
                }

            }

        }

        public static void LogPalindrome()
        {

            while(true)
            {

                Console.WriteLine("Enter a word or sentence:");

                string sentence = Console.ReadLine().ToLower();

                string trimedSentence = "";

                Stack<char> stack = new Stack<char>();

                foreach(char letter in sentence)
                {
                    if(letter != ' ')
                    {
                        trimedSentence += letter;

                        stack.Push(letter);
                    }
                }

                bool palindrome = true;

                for(int i = 0; i < trimedSentence.Length; i++)
                {
                    if(trimedSentence[i] != stack.Pop())
                    {
                        palindrome = false;
                    }
                }

                Console.WriteLine($"\nThis sentence is{(palindrome ? "" : " not")} a palindrome");

                Console.WriteLine("\nContinue? y/n");
                char answer = Console.ReadKey(true).KeyChar;

                if(answer == 'n')
                {
                    break;
                }

            }
        }

        public static void QueueLog()
        {

            queue = new Queues<char>(new char[] { 'F', 'I', 'L', 'O' });

            queue.Reverse();

            timer = new Timer();

            timer.Interval = 500;

            timer.Elapsed += LogQueueLetter;

            timer.Start();

            Console.ReadLine();

        }

        public static void LogQueueLetter(Object source, ElapsedEventArgs e)
        {
            Console.Write(queue.Pop());

            if(queue.isNull)
            {
                timer.Stop();
            }

        }

        public static void LogLinkedList()
        {

            LinkedList<string> linkedList = new LinkedList<string>();

            linkedList.Add("-------1");
            linkedList.Add("-------2");
            linkedList.Add("-------3");
            linkedList.Add("-------4");

            LogLinkedListNode(linkedList);

        }

        public static void LogLinkedListNode(LinkedList<string> linkedList)
        {

            if(linkedList.Count < 2)
                return;

            Console.WriteLine(linkedList.First().Next.Value);

            linkedList.Add("------");

            Console.WriteLine(linkedList.First().Next.Next.Value);

            linkedList.Remove();
            linkedList.Remove();

            LogLinkedListNode(linkedList);
        }

        public static void LogTreeBreadthFirst()
        {


            BinaryTree<string> binaryTree = new BinaryTree<string>(new BinaryTreeNode<string>("The root"));

            binaryTree.Root.AddRightChild("right node");

            binaryTree.Root.RightChild.AddRightChild("right node right child");

            binaryTree.Root.RightChild.AddLeftChild("right node left child");

            binaryTree.Root.RightChild.LeftChild.AddLeftChild("right node leaf");

            binaryTree.Root.AddLeftChild("left node");

            Console.WriteLine(binaryTree.ToStringLevelOrder());
        }


        public static void LogTreeDepthFirst()
        {

            BinaryTree<string> binaryTree = new BinaryTree<string>(new BinaryTreeNode<string>("1"));


            binaryTree.Root.AddRightChild("right node");

            binaryTree.Root.RightChild.AddRightChild("12");

            binaryTree.Root.RightChild.AddLeftChild("9");

            binaryTree.Root.RightChild.LeftChild.AddLeftChild("10");
            binaryTree.Root.RightChild.LeftChild.AddRightChild("11");

            binaryTree.Root.RightChild.RightChild.AddLeftChild("13");
            binaryTree.Root.RightChild.RightChild.AddRightChild("14");

            binaryTree.Root.AddLeftChild("2");

            binaryTree.Root.LeftChild.AddRightChild("6");

            binaryTree.Root.LeftChild.AddLeftChild("3");

            binaryTree.Root.LeftChild.LeftChild.AddLeftChild("4");
            binaryTree.Root.LeftChild.LeftChild.AddRightChild("5");

            binaryTree.Root.LeftChild.RightChild.AddLeftChild("7");
            binaryTree.Root.LeftChild.RightChild.AddRightChild("8");

            Console.WriteLine(binaryTree.PreOrder(4, binaryTree.Root));
            Console.WriteLine(binaryTree.InOrder(4, binaryTree.Root));
            Console.WriteLine(binaryTree.PostOrder(4, binaryTree.Root));
        }

        public static void LogSearchTree()
        {

            BinarySearchTree<int> binaryTree = new BinarySearchTree<int>(new BinaryTreeNode<int>(100));

            binaryTree.Insert(120);
            binaryTree.Insert(150);
            binaryTree.Insert(110);
            binaryTree.Insert(105);
            binaryTree.Insert(50);

            Console.WriteLine(binaryTree.ToStringLevelOrder());

            binaryTree.Insert(25);
            binaryTree.Insert(40);
            binaryTree.Insert(10);

            Console.WriteLine(binaryTree.ToStringLevelOrder());

            BinarySearchTree<int> secondBinaryTree = new BinarySearchTree<int>(new BinaryTreeNode<int>(100));

            Queues<int> queues = new Queues<int>(new int[] { 150, 25, 50, 125, 110, 105, 115 });

            secondBinaryTree.InsertMany(queues);

            Console.WriteLine();
            Console.WriteLine(secondBinaryTree.ToStringLevelOrder());
        }

        public static void LogMaxHeap()
        {

            MaxHeap<int> maxHeap = new MaxHeap<int>(new BinaryTreeNode<int>(100));

            Random random = new Random();

            int maxItems = random.Next(10, 25);

            int[] items = new int[maxItems];

            for(int i = 0; i < maxItems; i++)
            {
                int item = random.Next(10, 1000);

                Console.Write($"({item})");

                items[i] = item;

                maxHeap.Insert(item);
            }
            Console.WriteLine("\n");

            Console.WriteLine(maxHeap.ToStringLevelOrder());

            Console.WriteLine("\n");

            int numOfRemovedItems = random.Next(1, maxItems / 2);

            for(int i = 0; i < numOfRemovedItems; i++)
            {

                int item = random.Next(0, maxItems);

                maxHeap.Delete(items[item]);

                Console.Write($"({items[item]})");
            }

            Console.WriteLine("\n");

            Console.WriteLine(maxHeap.ToStringLevelOrder());

            Console.WriteLine();

            Console.WriteLine(maxHeap.Extract());
            Console.WriteLine(maxHeap.ToStringLevelOrder());

            Console.WriteLine();

            Console.WriteLine(maxHeap.Search(3, 2, maxHeap.Root));

        }

        public static void LogMinHeap()
        {

            MinHeap<int> minHeap = new MinHeap<int>(new BinaryTreeNode<int>(100));

            Random random = new Random();

            int maxItems = 20;

            int[] items = new int[20] { 708, 715, 325, 707, 162, 855, 607, 818, 175, 57, 323, 713, 176, 975, 910, 886, 45, 284, 49, 729 };

            for(int i = 0; i < maxItems; i++)
            {
                //int item = random.Next(10, 1000);
            
                Console.Write($"({items[i]})");
            
                //items[i] = item;
            
                minHeap.Insert(items[i]);
            }
            Console.WriteLine("\n");

            Console.WriteLine(minHeap.ToStringLevelOrder());

            Console.WriteLine("\n");

            int numOfRemovedItems = 4;

            for(int i = 0; i < numOfRemovedItems; i++)
            {

                int item = random.Next(0, maxItems);

                minHeap.Delete(items[item]);

                Console.Write($"({items[item]})");
            }

            Console.WriteLine("\n");

            Console.WriteLine(minHeap.ToStringLevelOrder());

            Console.WriteLine();

            Console.WriteLine(minHeap.Extract());
            Console.WriteLine(minHeap.ToStringLevelOrder());

            Console.WriteLine();

            Console.WriteLine(minHeap.Search(3, 2, minHeap.Root));

        }

        public static void LogAVLTree()
        {
            AVLTree<int> tree = new AVLTree<int>(new BinaryTreeNode<int>(400)); 
            
            int[] items = new int[20] { 708, 715, 325, 707, 162, 855, 607, 818, 175, 57, 323, 713, 176, 975, 910, 886, 45, 284, 49, 729 };

            foreach(int item in items)
            {
                tree.Insert(item);
            }

            Console.WriteLine(tree.ToStringLevelOrder());

        }

        public static void LogLinearTree()
        {
            LinearBinaryTree<string> linearBinaryTree = new LinearBinaryTree<string>("400");
            BinarySearchTree<string> searchTree = new BinarySearchTree<string>(new BinaryTreeNode<string>("400"));

            int[] items = new int[20] { 708, 715, 325, 707, 162, 855, 607, 818, 175, 57, 323, 713, 176, 975, 910, 886, 45, 284, 49, 729 };

            foreach(int item in items)
            {
                linearBinaryTree.SearchInsert(0, item.ToString());
                searchTree.Insert(item.ToString());
            }

            for(int i = 0; i < linearBinaryTree.Count; i++)
            {

                string value = linearBinaryTree.GetValue(i);

                Console.WriteLine($"{linearBinaryTree.GetValue(i)} | {linearBinaryTree.GetParent(i)}");
            }

            long linearAverage = 0;
            long nonLinearAverage = 0;

            for(int i = 0; i < 5; i++)
            {

                Console.WriteLine();

                Stopwatch watch = Stopwatch.StartNew();

                int linearIndex = linearBinaryTree.Search("607");

                watch.Stop();

                Console.WriteLine($"{linearBinaryTree.GetValue(linearIndex)} | {linearBinaryTree.GetParent(linearIndex) == "707"} :" +
                    $" {watch.Elapsed.Ticks}");

                linearAverage += watch.Elapsed.Ticks;

                watch = Stopwatch.StartNew();

                BinaryTreeNode<string> nonLinearValue = searchTree.BinarySearch("607", searchTree.Root);

                watch.Stop();

                Console.WriteLine($"{nonLinearValue.Value} | {nonLinearValue.Parent.Value == "707"} :" +
                    $" {watch.Elapsed.Ticks}");

                nonLinearAverage += watch.Elapsed.Ticks;
            }

            Console.WriteLine();

            Console.WriteLine($"{linearAverage / 5}");
            Console.WriteLine($"{nonLinearAverage / 5}");

        }

        public static void LogHashTable()
        {

            HashTable<string, int> hashTable = new HashTable<string, int>();

            for(int i = 1; i < 1000; i++)
            {
                hashTable.Add(i.ToString(), i);

                if(i == 795)
                    Console.WriteLine(hashTable.LookUp("685"));

            }

            Console.WriteLine(hashTable.LookUp("685"));
            Console.WriteLine();

            ChainableHashTable<string, int> chainableHashTable = new ChainableHashTable<string, int>();

            for(int i = 1; i < 1000; i++)
            {
                chainableHashTable.Add(i.ToString(), i);

                if(i == 795)
                    Console.WriteLine(chainableHashTable.LookUp("685"));

            }

            Console.WriteLine(chainableHashTable.LookUp("685"));
            Console.WriteLine();

            HeadHashTable<string, int> headHashTable = new HeadHashTable<string, int>();

            for(int i = 1; i < 1000; i++)
            {
                headHashTable.Add(i.ToString(), i);

                if(i == 795)
                    Console.WriteLine(headHashTable.LookUp("685"));

            }

            Stopwatch watch = Stopwatch.StartNew();

            int value = headHashTable.LookUp("685");

            watch.Stop();

            Console.WriteLine(value + " :" + watch.Elapsed.Ticks);
            Console.WriteLine();

            TreeHashTable<string, int> treeHashTable = new TreeHashTable<string, int>();

            for(int i = 1; i < 1000; i++)
            {
                treeHashTable.Add(i.ToString(), i);

                if(i == 795)
                    Console.WriteLine(treeHashTable.LookUp("685"));

            }
            watch = Stopwatch.StartNew();

            value = treeHashTable.LookUp("685");

            watch.Stop();

            Console.WriteLine(value + " :" + watch.Elapsed.Ticks);


        }

    }       
}           
            