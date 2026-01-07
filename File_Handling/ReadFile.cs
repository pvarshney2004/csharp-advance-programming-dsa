using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.File_Handling
{
    /*
     Problem: Write a program that uses StreamReader to read a text file line by line and print
each line to the console.
     */
    internal class ReadFile
    {
        public void Read()
        {
            string filePath = "sample.txt";
            try
            {
                using(StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            } catch(IOException e)
            {
                Console.WriteLine (e.Message);
            }
        }
    }
}
