using DataStructures;
using System;
using System.Text;
using System.Windows;
using System.Windows.Media;

namespace TowersOfHanoi
{
    public class ViewModel
    {

        private Stack<int> firstDiskStack;
        private Stack<int> secondDiskStack;
        private Stack<int> thirdDiskStack;

        private Stack<int>[] stacks;

        public Stack<int>[] Stacks => stacks;
        public int RingNumber { get; set; }

        public ViewModel()
        {

            firstDiskStack = new Stack<int>();
            secondDiskStack = new Stack<int>();
            thirdDiskStack = new Stack<int>();

            stacks = new Stack<int>[] { firstDiskStack, secondDiskStack, thirdDiskStack };

            RingNumber = 3;
        }

        public bool PlaceDisk(int newStack, int oldStack, int disk)
        {

            if(stacks[newStack].Peek() <= disk && !stacks[newStack].isNull)
            {
                return false;
            }

            stacks[newStack].Push(disk);

            if(!stacks[oldStack].isNull)
            {
                stacks[oldStack].Pop();
            }

            return true;
        }

        public bool PlaceDisk(int newStack, int oldStack)
        {

            return PlaceDisk(newStack, oldStack, stacks[oldStack].Peek());

        }

        public void ResetStacks(int i)
        {
            stacks[i] = new Stack<int>();
        }


    }
}
