using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Delegates
{
    /*
     Delegate as Method Parameter
Write a method PerformOperation(int a, int b, DelegateName op)
Pass different operations using delegates.
     */
    public delegate void MyDelegate(string msg);
    internal class DelegateAsParameter
    {
        public static void InvokeDelegate(MyDelegate del)
        {
            del("Hello world");
        }
        public static void Greet(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
