using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Searching
{
    /*
     Problem: A peak element is an element that is greater than its neighbors. Write a program
that performs Binary Search to find a peak element in an array.
     */
    internal class PeakElement
    {
        // ex: ar = {1,2,1,3,5,6,4} -> answer- index 5
        public int Find(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                int mid = (i+ j) / 2;
                if (arr[mid] < arr[mid + 1])
                {
                    i = mid+1;
                }
                else
                {
                    j = mid;
                }
            }
            return i;
        }
    }
}
