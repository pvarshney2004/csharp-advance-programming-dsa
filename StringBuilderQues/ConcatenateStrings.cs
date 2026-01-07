using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.StringBuilderQues
{
    /*
     Problem: You are given an array of strings. Write a program that uses StringBuilder to
concatenate all the strings in the array efficiently.
     */
    internal class ConcatenateStrings
    {
        public void Solve(string[] arr)
        {
            StringBuilder sb = new StringBuilder();
            foreach(string s in arr)
            {
                sb.Append(s);
            }
            Console.WriteLine("Output: " + sb.ToString());
        }
    }
}
