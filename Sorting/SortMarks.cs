using System;

namespace Advance_Programming_DSA.Sorting
{
    public class SortMarks
    {
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
