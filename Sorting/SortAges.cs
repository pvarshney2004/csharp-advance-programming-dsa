using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Sorting
{
    /*
     7. Counting Sort - Sort Student Ages
Problem Statement:
A school collects students’ ages (ranging from 10 to 18) and wants them sorted. Implement
Counting Sort in C# for this task.
Hint:
● Create a count array to store the frequency of each age.
● Compute cumulative frequencies to determine positions.
● Place elements in their correct positions in the output array.
     */
    internal class SortAges
    {
        public int[] Sort(int[] ages)
        {
            int max = ages[0];
            foreach(int age in ages)
            {
                if (age > max)
                {
                    max = age;
                }
            }

            int[] countArr = new int[max + 1];
            foreach(int i in ages){
                countArr[i]++;
            }
            for(int i=1; i <= max; i++)
            {
                countArr[i] = countArr[i]+countArr[i-1];
            }

            int[] ans = new int[ages.Length];
            for(int i=ages.Length-1; i>=0; i--)
            {
                int f = ages[i];
                ans[countArr[f] - 1] = f;

                countArr[f]--;
            }
            return ans;
        }
    }
}
