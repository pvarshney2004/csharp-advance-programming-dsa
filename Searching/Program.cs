using Advance_Programming_DSA.Searching;
using System;
namespace Searching
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            FirstNegative obj = new FirstNegative();
            int[] arr = { 5, 6, -3, 7, -2, 4, -8 };
            int idx = obj.Find(arr);
            if (idx != -1)
            {
                Console.WriteLine("First negative number in the array is: " + arr[idx]);
            }
            else
            {
                Console.WriteLine("No negative numbers present in array");
            }
            */


            /*
            SearchWord obj2 = new SearchWord();
            string[] sentences = { "hello how are you", "you are a man", "what are you doing" };
            string word = "you";
            int i = obj2.Search(sentences, word);
            if (i != -1)
            {
                Console.WriteLine($"First sentence containing \'{word}\' is: " + sentences[i]);
            }
            else
            {
                Console.WriteLine($"No sentences contains the word \'{word}\'");
            }
            */


            //FindSmallest obj3 = new FindSmallest();
            //int[] arr = { 3, 4, 5, 1, 2 };
            //int idx = obj3.Find(arr);
            //Console.WriteLine($"Smallest element in array is: {arr[idx]}");


            //PeakElement obj4 = new PeakElement();
            //int[] arr = { 1, 2, 1, 3, 5, 6, 4 };
            //int idx = obj4.Find(arr);
            //Console.WriteLine($"Peak element is at the index: {idx}");


            /*
            int[,] arr = { { 1, 3, 5, 7 }, { 10, 11, 16, 20 }, { 23, 30, 34, 60 } };
            int target = 3;
            SearchMatrix obj5 = new SearchMatrix();
            bool isPresent = obj5.Search(arr, target);
            if (isPresent)
            {
                Console.WriteLine("Array contains the target element");
            }
            else
            {
                Console.WriteLine("Array does not contains the target element");
            }
            */


            //int[] arr = { 5, 7, 7, 8, 8, 10 };
            //int target = 8;
            //FindFirstAndLast obj6 = new FindFirstAndLast();
            //int[] ans = new int[2] { -1, -1 };
            //ans[0] = obj6.Find(arr, target, true);
            //ans[1] = obj6.Find(arr, target, false);
            //Console.WriteLine($"First occurence of {target} is at index {ans[0]} and last occurence at index {ans[1]}");


            int[] arr = { 3, 4, -1, 1 };
            Combine obj7 = new Combine();
            int firstMissingPos = obj7.FirstMissingPositive(arr);
            Console.WriteLine($"First missing positive integer in array is: {firstMissingPos}");
            Array.Sort(arr);
            int target = -1;
            int idx = obj7.Search(arr, target);
            if (idx != -1)
            {
                Console.WriteLine($"Index for {target} is: {idx}");
            }
            else
            {
                Console.WriteLine($"Target element not present in array");
            }

        }
    }
}