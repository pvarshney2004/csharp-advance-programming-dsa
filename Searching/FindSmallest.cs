using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Searching
{
    /*
     Problem: You are given a rotated sorted array. Write a program that performs Binary Search
to find the index of the smallest element in the array.
     */
    internal class FindSmallest
    {
        public int Find(int[] arr)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i < j)
            {
                int mid = (i + j) / 2;
                if (arr[mid] > arr[j])
                {
                    i  = mid + 1;
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
