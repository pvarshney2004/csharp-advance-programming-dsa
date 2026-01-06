using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Sorting
{
    /*
     5. Selection Sort - Sort Exam Scores
Problem Statement:
A university needs to sort students’ exam scores in ascending order. Implement Selection
Sort in C# to achieve this.
Hint:
● Find the minimum element in the array.
● Swap it with the first unsorted element.
● Repeat the process for the remaining elements
     */
    internal class SortScores
    {
        public void Sort(int[] scores)
        {
            for(int i=0; i<scores.Length; i++)
            {
                int minIdx = MinIndex(scores, i);
                int temp = scores[i];
                scores[i] = scores[minIdx];
                scores[minIdx] = temp;
            }
        }
        public static int MinIndex(int[] arr, int i)
        {
            int mini = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[mini])
                {
                    mini = j;
                }

            }
            return mini;
        }
    }
}
