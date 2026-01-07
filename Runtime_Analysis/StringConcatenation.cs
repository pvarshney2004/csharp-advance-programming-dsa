using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Runtime_Analysis
{
    /*
     3. String Concatenation Performance
Objective
Compare the performance of string (O(N²)), StringBuilder (O(N)), and StringBuffer (O(N))
when concatenating a million strings.
Approach
● Using string (Immutable, creates a new object each time)
● Using StringBuilder (Fast, mutable, thread-unsafe)w
     */
    internal class StringConcatenation
    {
        public static void Compare(int n)
        {
            // Using string concatenation
            Stopwatch sw1 = Stopwatch.StartNew();
            string str = "";
            for (int i = 0; i < n; i++)
            {
                str += "hello";
            }
            sw1.Stop();

            // Using StringBuilder concatenation
            Stopwatch sw2 = Stopwatch.StartNew();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                sb.Append("hello");
            }
            sb.ToString();
            sw2.Stop();

            Console.WriteLine("String concatenation Time: " + sw1.ElapsedMilliseconds + " ms");
            Console.WriteLine("StringBuilder concatenation Time: " + sw2.ElapsedMilliseconds + " ms");
        }
    }
}
