
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Runtime_Analysis
{
    /*
     2. Sorting Large Data Efficiently
Objective
Compare sorting algorithms Bubble Sort (O(N²)), Merge Sort (O(N log N)), and Quick Sort
(O(N log N)).
Approach
● Bubble Sort: Repeated swapping (inefficient for large data).
● Merge Sort: Divide & Conquer approach (stable).
● Quick Sort: Partition-based approach (fast but unstable).
     */
    internal class SortingComparison
    {
        // bubble sort
        public static void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        // merge Sort
        public static void MergeSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;

            int mid = (left + right) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);
            Merge(arr, left, mid, right);
        }
        public static void Merge(int[] arr, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] L = new int[n1];
            int[] R = new int[n2];

            for (int i = 0; i < n1; i++)
                L[i] = arr[left + i];

            for (int j = 0; j < n2; j++)
                R[j] = arr[mid + 1 + j];

            int iIndex = 0, jIndex = 0, k = left;

            while (iIndex < n1 && jIndex < n2)
            {
                if (L[iIndex] <= R[jIndex])
                    arr[k++] = L[iIndex++];
                else
                    arr[k++] = R[jIndex++];
            }

            while (iIndex < n1)
                arr[k++] = L[iIndex++];

            while (jIndex < n2)
                arr[k++] = R[jIndex++];
        }

        // quick sort
        static void QuickSort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                int pi = Partition(arr, low, high);
                QuickSort(arr, low, pi - 1);
                QuickSort(arr, pi + 1, high);
            }
        }
        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = low - 1;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }
            int temp2 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp2;
            return i + 1;
        }

        // method for comparing three above algorithms
        public static void Compare(int[] arr)
        {
            Stopwatch sw = new Stopwatch();

            sw.Start();
            Sort(arr);
            sw.Stop();
            Console.WriteLine("Bubble Sort Time: " + sw.ElapsedMilliseconds + " ms");

            sw.Restart();
            MergeSort(arr, 0, arr.Length - 1);
            sw.Stop();
            Console.WriteLine("Merge Sort Time: " + sw.ElapsedMilliseconds + " ms");

            sw.Restart();
            QuickSort(arr, 0, arr.Length - 1);
            sw.Stop();
            Console.WriteLine("Quick Sort Time: " + sw.ElapsedMilliseconds + " ms");
        }

    }
}
