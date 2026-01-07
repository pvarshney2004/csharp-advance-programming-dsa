using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Searching
{
    /*
     Problem: Given a sorted array and a target element, write a program that uses Binary Search
to find the first and last occurrence of the target element in the array.
     */
    internal class FindFirstAndLast
    {
        public int Find(int[] arr, int target, bool isLeft)
        {
            int i = 0;
            int j = arr.Length - 1;
            int idx = -1;
            while (i <= j)
            {
                int mid = (i + j) / 2;
                if (arr[mid] > target)
                {
                    j = mid - 1;
                }
                else if (arr[mid] <  target)
                {
                    i = mid + 1;
                }
                else
                {
                    idx = mid;
                    if (isLeft)
                    {
                        j = mid - 1;
                    }
                    else
                    {
                        i = mid + 1;
                    }
                }
            }
            return idx;
        }
    }
}
