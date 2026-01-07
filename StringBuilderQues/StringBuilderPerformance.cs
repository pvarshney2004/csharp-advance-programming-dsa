using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.StringBuilderQues
{
    /*
     Problem: Write a program that compares the performance of StringBuilder for
concatenating strings multiple times.
     */
    internal class StringBuilderPerformance
    {
        public void Compare()
        {
            int n = 10000;

            // Using string concatenation
            Stopwatch sw1 = Stopwatch.StartNew();
            string str = "";
            for (int i = 0; i < n; i++)
            {
                str += "A";
            }
            sw1.Stop();

            // Using StringBuilder concatenation
            Stopwatch sw2 = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append("A");
            }
            sb.ToString();
            sw2.Stop();

            Console.WriteLine("String concatenation Time: " + sw1.ElapsedMilliseconds + " ms");
            Console.WriteLine("StringBuilder concatenation Time: " + sw2.ElapsedMilliseconds + " ms");
        }
    }
}
