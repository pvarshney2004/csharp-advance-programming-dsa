using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Delegates
{
    /*
     Multicast Delegate
Create a delegate that returns void.
Attach multiple methods and observe the execution order.
     */

    public delegate void MyDel();
    internal class MulticastDelegate
    {
        public static void MethodA()
        {
            Console.WriteLine("Method A");
        }

        public static void MethodB()
        {
            Console.WriteLine("Method B");
        }
    }
}
