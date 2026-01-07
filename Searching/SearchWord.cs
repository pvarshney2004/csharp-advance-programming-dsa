using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Searching
{
    /*
     Problem: You are given an array of sentences. Write a program that performs Linear Search
to find the first sentence containing a specific word.
     */
    internal class SearchWord
    {
        public int Search(string[] sentences, string word)
        {
            for(int i=0; i < sentences.Length; i++)
            {
                if (sentences[i].Contains(word))
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
