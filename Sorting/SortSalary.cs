using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Sorting
{
    /*
     6. Heap Sort - Sort Job Applicants by Salary
Problem Statement:
A company receives job applications with different expected salary demands. Implement
Heap Sort in C# to sort these salary demands in ascending order.
Hint:
● Build a Max Heap from the array.
● Extract the largest element (root) and place it at the end.
● Reheapify the remaining elements and repeat until sorted.
     */
    internal class SortSalary
    {
        public void Sort(int[] salary)
        {
            int n = salary.Length;
            for(int i=n/2-1; i>=0; i--)
            {
                Heapify(salary, n, i);
            }
            for (int i = n - 1; i > 0; i--)
            {
                int temp = salary[0];
                salary[0] = salary[i];
                salary[i] = temp;
                Heapify(salary, i, 0);
            }

        }

        public void Heapify(int[] salary, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if(left < n && salary[left] > salary[largest])
            {
                largest = left;
            }
            if(right < n && salary[right] > salary[largest])
            {
                largest = right;
            }
            if (largest != i)
            {
                int temp = salary[i];
                salary[i] = salary[largest];
                salary[largest] = temp;
                Heapify(salary, n, largest);
            }
        }
    }
}
