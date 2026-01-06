using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Sorting
{
    /*
     4. Quick Sort - Sort Product Prices
Problem Statement:
An e-commerce company wants to display product prices in ascending order. Implement
Quick Sort in C# to sort the product prices.
Hint:
● Pick a pivot element (first, last, or random).
● Partition the array such that elements smaller than the pivot are on the left and
larger ones are on the right.
● Recursively apply Quick Sort on left and right partitions.
     */
    internal class SortProductPrices
    {
        public void Sort(int[] arr, int si, int ei)
        {
            if (si >= ei)
            {
                return;
            }
            int idx = Partition(arr, si, ei);
            Sort(arr, si, idx - 1);
            Sort(arr, idx + 1, ei);
        }

        public static int Partition(int[] arr, int si, int ei)
        {
            int item = arr[ei];
            int idx = si;
            for (int i = si; i < ei; i++)
            {
                if (arr[i] <= item)
                {
                    int temp = arr[idx];
                    arr[idx] = arr[i];
                    arr[i] = temp;
                    idx++;

                }
            }
            int temp2 = arr[idx];
            arr[idx] = arr[ei];
            arr[ei] = temp2;
            return idx;
        }
    }
}
