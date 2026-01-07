using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Searching
{
    /*
     Problem: You are given an integer array. Write a program that performs Linear Search to find
the first negative number in the array.
     */
    internal class FirstNegative
    {
        public int Find(int[] arr)
        {
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] < 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
