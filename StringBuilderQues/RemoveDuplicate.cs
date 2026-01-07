using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.StringBuilderQues
{
    /*
     Problem: Write a program that uses StringBuilder to remove all duplicate characters from a
given string while maintaining the original order.
     */
    internal class RemoveDuplicate
    {
       public void Remove(string str)
        {
            StringBuilder sb = new StringBuilder();
            bool[] seen = new bool[256]; 

            foreach (char c in str)
            {
                if (!seen[c])
                {
                    sb.Append(c);
                    seen[c] = true;
                }
            }
            Console.WriteLine($"Original String: {str} | Updated String: {sb.ToString()}");
        }
    }
}
