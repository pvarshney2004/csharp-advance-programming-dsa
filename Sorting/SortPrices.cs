using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Sorting
{
    /*
     3. Merge Sort - Sort an Array of Book Prices
Problem Statement:
A bookstore maintains a list of book prices in an array. Implement Merge Sort in C# to sort
the prices in ascending order.
Hint:
● Divide the array into two halves recursively.
● Sort both halves individually.
● Merge the sorted halves by comparing elements
     */
    internal class SortPrices
    {
        public int[] Sort(int[] prices, int i, int j)
        {
            if (i == j)
            {
                return new int[1] { prices[i] };
            }
            int mid = (i + j) / 2;
            int[] left = Sort(prices, i, mid);
            int[] right = Sort(prices, mid+1, j);
            return Merge(left, right);
        }

        public int[] Merge(int[] arr1, int[] arr2)
        {
            int n = arr1.Length;
            int m = arr2.Length;
            int[] ans = new int[n + m];
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < n && j < m)
            {
                if (arr1[i] < arr2[j])
                {
                    ans[k] = arr1[i];
                    i++;
                }
                else
                {
                    ans[k] = arr2[j];
                    j++;
                }
                k++;
            }
            while (i < n)
            {
                ans[k++] = arr1[i++];
            }
            while (j < m)
            {
                ans[k++] = arr2[j++];
            }
            return ans;
        }
    }
}
