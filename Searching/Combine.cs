using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Searching
{
    /*
     Problem:
You are given a list of integers. Write a program that uses Linear Search to find the first
missing positive integer in the list and Binary Search to find the index of a given target
number.
Approach:
1. Linear Search for the first missing positive integer:
o Iterate through the list and mark each number in the list as visited (you can
use negative marking or a separate array).
o Traverse the array again to find the first positive integer that is not marked.
2. Binary Search for the target index:
o After sorting the array, perform binary search to find the index of the given
target number.
o Return the index if found, otherwise return -1.
     */
    internal class Combine
    {
        // performing linear search
        // 3,4,-1,1
        public int FirstMissingPositive(int[] arr)
        {
            int n = arr.Length;
            bool[] visited = new bool[n + 1];
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    visited[i] = true;
                }
            }

            for (int i = 1; i <= n; i++)
            {
                if (visited[i] == false)
                {
                    return i; // first missing positive
                }
            }
            return n + 1;
        }


        // performing binary search
        public int Search(int[] arr, int target)
        {
            int i = 0;
            int j = arr.Length - 1;
            while (i <= j)
            {
                int mid = (i + j) / 2;
                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] > target)
                {
                    j = mid - 1;
                }
                else
                {
                    i = mid + 1;
                }
            }
            return -1;
        }
    }
}
