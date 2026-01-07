using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.StringBuilderQues
{
    /*
     Problem: Write a program that uses StringBuilder to reverse a given string. For example, if
the input is "hello", the output should be "olleh".
     */
    internal class Reverse
    {
        public void ReverseString(string str)
        {
            StringBuilder sb = new StringBuilder();
            for(int i = str.Length-1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }
            Console.WriteLine($"Original String: {str} | Reversed String: {sb.ToString()}");

        }
    }
}
