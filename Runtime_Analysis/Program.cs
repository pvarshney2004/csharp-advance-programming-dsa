using System;
namespace Advance_Programming_DSA.Runtime_Analysis
{
    class Program
    {
        public static void Main(string[] args)
        {
            //Fibonacci.Compare(37);
            //Fibonacci.Compare(30);


            //StringConcatenation.Compare(1000);
            //StringConcatenation.Compare(10000);
            //StringConcatenation.Compare(1000000);


            //// taking random array data for comparision
            //int[] arr = new int[5000];
            //Random rand = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rand.Next(1, 10000);
            //}
            //SortingComparison.Compare(arr);


            /*
            //int n = 100000; // gives 0ms for both in my system
            int n = 1000000; 
            int[] arr = new int[n];
            for(int i=0; i<n; i++)
            {
                // initializing array value by index
                arr[i] = i;
            }
            int target = n - 2; // large value for searching
            SearchTarget.Compare(arr, target);
            */


            string path = "sample.txt";
            FileReading.Compare(path);





        }
    }
}