using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Sorting
{
    /*
     2. Insertion Sort - Sort Employee IDs
Problem Statement:
A company stores employee IDs in an unsorted array. Implement Insertion Sort in C# to sort
the employee IDs in ascending order.
Hint:
● Divide the array into sorted and unsorted parts.
● Pick an element from the unsorted part and insert it into its correct position in the
sorted part.
● Repeat for all elements
     */
    internal class SortIDs
    {
        public void Sort(int[] Ids)
        {
            for(int i=1; i<Ids.Length; i++)
            {
                int key = Ids[i];
                int j = i - 1;
                while (j >= 0 && Ids[j] > key)
                {
                    Ids[j + 1] = Ids[j];
                    j--;
                }
                Ids[j + 1] = key;
            }
        }
    }
}
