using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Delegates
{
    /*
     Delegate with void Return Type
Define a delegate that prints a message.
Pass different methods to display:

Welcome message
Error message
Success message
     */
    public delegate void Print(string msg);
    internal class Messages
    {
        public static void WelcomeMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void ErrorMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void SuccessMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
