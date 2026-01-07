using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Runtime_Analysis
{
    /*
     5. Recursive vs Iterative Fibonacci Computation
Objective
Compare Recursive (O(2^N)) vs Iterative (O(N)) Fibonacci solutions.
     */
    internal class Fibonacci
    {
        // method for recursive fibonacci
        public static int FibonacciRecursive(int n)
        {
            if (n == 0 || n == 1) return n;
            int a = FibonacciRecursive(n - 1);
            int b = FibonacciRecursive(n - 2);
            return a + b;
        }

        // method for iterative fibonacci
        public static int FibonacciIterative(int n)
        {
            int a = 0, b = 1, sum;
            for (int i = 2; i <= n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return b;
        }
        // comparision
        public static void Compare(int n)
        {
            Stopwatch sw1 = Stopwatch.StartNew();
            FibonacciIterative(n);
            sw1.Stop();

            Stopwatch sw2 = Stopwatch.StartNew();
            FibonacciRecursive(n);
            sw2.Stop();

            Console.WriteLine($"Fibonacci for {n} using Iterative Time: " + sw1.ElapsedMilliseconds + " ms");
            Console.WriteLine($"Fibonacci for {n} using Recursive Time: " + sw2.ElapsedMilliseconds + " ms");

        }


    }
}
