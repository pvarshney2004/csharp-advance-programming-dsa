using System;

namespace Advance_Programming_DSA.Sorting
{
    public class SortMarks
    {
        /*
         1. Bubble Sort - Sort Student Marks
Problem Statement:
A school maintains student marks in an array. Implement Bubble Sort in C# to sort the
student marks in ascending order.
Hint:
● Traverse through the array multiple times.
● Compare adjacent elements and swap them if needed.
● Repeat the process until no swaps are required.

         */
        public void Sort(int[] marks)
        {
            for(int i=0; i<marks.Length; i++)
            {
                for(int j=0; j<marks.Length-i-1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                    }
                }
            }
        }
    }
}
