using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Advance_Programming_DSA.Runtime_Analysis
{
    /*
     1. Search a Target in a Large Dataset
Objective
Compare the performance of Linear Search (O(N)) and Binary Search (O(log N)) on different
dataset sizes.
Approach
● Linear Search: Scan each element until the target is found.
● Binary Search: Sort the data first (O(N log N)), then perform O(log N) search.
     */
    internal class SearchTarget
    {
        // method for linear search
        public static int LinearSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                    return i;
            }
            return -1;
        }

        // method for binary search
        public static int BinarySearch(int[] arr, int target)
        {
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;

                if (arr[mid] == target)
                {
                    return mid;
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        // method for comparing both
        public static void Compare(int[] arr, int target)
        {
            Stopwatch sw1 = Stopwatch.StartNew();
            LinearSearch(arr, target);
            sw1.Stop();

            Stopwatch sw2 = Stopwatch.StartNew();
            BinarySearch(arr, target);
            sw2.Stop();

            Console.WriteLine("Linear Search Time: " + sw1.ElapsedMilliseconds + " ms");
            Console.WriteLine("Binary Search Time: " + sw2.ElapsedMilliseconds + " ms");
        }
    }
}
