using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Runtime_Analysis
{
    /*
     4. Large File Reading Efficiency
Objective
Compare StreamReader and FileStream when reading a large file (500MB).
Approach
● StreamReader: Reads character by character (slower for binary files).
● FileStream: Reads bytes and converts to characters (more efficient).
     */
    internal class FileReading
    {
        // reading with streamreader
        public static void ReadingUsingStreamReader(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                while (reader.Read() != -1)
                {
                    // reading character by character
                }
            }
        }

        // reading with filestream
        public static void ReadingUsingFileStream(string path)
        {
            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[4096];
                while (fs.Read(buffer, 0, buffer.Length) > 0)
                {
                    // reading bytes in chunks
                }
            }
        }

        // comparing both
        public static void Compare(string filePath)
        {
            Stopwatch sw1 = Stopwatch.StartNew();
            ReadingUsingStreamReader(filePath);
            sw1.Stop();

            Stopwatch sw2 = Stopwatch.StartNew();
            ReadingUsingFileStream(filePath);
            sw2.Stop();

            Console.WriteLine("StreamReader Time: " + sw1.ElapsedMilliseconds + " ms");
            Console.WriteLine("FileStream Time: " + sw2.ElapsedMilliseconds + " ms");
        }
    }
}
