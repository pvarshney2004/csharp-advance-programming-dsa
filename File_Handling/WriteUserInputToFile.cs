using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.File_Handling
{
    internal class WriteUserInputToFile
    {
        public void Write()
        {
            string filePath = "output.txt";

            Console.WriteLine("Enter text that you want to write in file:");
            string input = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(input);
                Console.WriteLine("Data written to the output file successfully.");
            }
        }
    }
}
