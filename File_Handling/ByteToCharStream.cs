using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.File_Handling
{
    /*
     Problem: Write a program that uses StreamReader to read binary data from a file and print
it as characters.
     */
    internal class ByteToCharStream
    {
        public void Print()
        {
            string filePath = "sample.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                int ch;
                while ((ch = reader.Read()) != -1)
                {
                    Console.Write((char)ch+" ");
                }
            }
        }
    }
}
