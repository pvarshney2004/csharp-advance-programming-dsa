using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Delegates
{
    /*
     Simple Delegate Invocation
Create a delegate that takes two integers and returns an integer.
Implement methods for Add, Subtract, Multiply, and invoke them using the delegate.
     */
    public delegate int Operation(int num1, int num2);
    public class Calculation
    {
        public static int Add(int num1, int num2)
        {
            return num1+num2;
        }
        public static int Substract(int num1, int num2)
        {
            return num1-num2;
        }
        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
