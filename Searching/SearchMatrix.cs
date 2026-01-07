using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Searching
{
    /*
     Problem: You are given a 2D matrix where each row is sorted in ascending order. Write a
program that performs Binary Search to find a target value in the matrix.
     */
    internal class SearchMatrix
    {
        public bool Search(int[,] arr, int target)
        {
            int r = 0;
            int c = arr.GetLength(1) - 1;
            while(r<arr.GetLength(0) && c >= 0)
            {
                if(arr[r, c] == target)
                {
                    return true;
                }
                else if (arr[r,c] > target)
                {
                    c--;
                }
                else
                {
                    r++;
                }
            }
            return false;
        }
    }
}
