using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Delegates
{
    /*
     Delegate vs Func/Action
Rewrite a custom delegate using:
Func<int, int, int>
Action<string>
     */

    internal class DelegateVsFuncAct
    {
        public static void Execute()
        {
            // using Func
            Console.WriteLine("Custom delegate using Func");
            Func<int, int, int> add = (a, b) => a + b;
            Console.WriteLine("Sum: " + add(5, 3));
            
            // using Action
            Console.WriteLine("Custom delegate using Action");
            Action<string> log = msg => Console.WriteLine(msg);
            log("Hello World for Action");
        }
    }
}
