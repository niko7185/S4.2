using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    public class SearchAlgorithms
    {

        public static bool NumericlySorted(int[] nums)
        {
            if(nums.Length < 2)
                return true;

            for(int i = 0; i < nums.Length - 1; i += 1)
            {
                if(nums[i] > nums[i + 1])
                    return false;
            }

            return true;

        }

        public static int FindNumber(int[] nums, long number)
        {

            //bool sorted = NumericlySorted(nums);
            //
            //if(!sorted)
            //    return -1;

            int left = 0;
            int mid = 0;
            int right = nums.Length - 1;

            bool searchingRight = ((left + right) / 2) < number;

            while(left < right)
            {

                mid = (left + right) / 2;

                bool isNextDuplicate = false;

                if(mid < right && searchingRight)
                {
                    isNextDuplicate = nums[mid + 1] == number && nums[mid] == number;
                }

                if(nums[mid] < number || isNextDuplicate)
                    left = mid + 1;
                else
                    right = mid;
            }

            return nums[left] == number ? left : -1;

        }

        public static int LinearFindNumber(int[] nums, long number)
        {

            for(int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == number)
                {
                    return i;
                }
            }

            return -1;
        }

    }
}
