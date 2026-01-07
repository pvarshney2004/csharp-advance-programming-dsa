using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.File_Handling
{
    /*
     Problem: Write a program that reads a file and counts how many times a specific word
appears in the file
     */
    internal class CountWord
    {
        public void Count(string targetWord)
        {
            string filePath = "sample.txt";     
            int count = 0;
            string content = File.ReadAllText(filePath);
            string[] words = content.Split(
                new char[] { ' ', '\n', '\r', '\t', ',', '.', '!' },
                StringSplitOptions.RemoveEmptyEntries
            );
            foreach (string word in words)
            {
                if (word.Equals(targetWord, StringComparison.OrdinalIgnoreCase))
                {
                    count++;
                }
            }
            Console.WriteLine($"The word '{targetWord}' appears {count} times.");
        }
    }
}
