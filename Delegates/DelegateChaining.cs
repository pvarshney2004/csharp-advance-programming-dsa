using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Delegates
{
    /*
     Delegate Chaining & Removal
Add multiple methods to a delegate and remove one method at runtime.
     */
    public delegate void Notify();
    internal class DelegateChaining
    {
        public static void Execute()
        {
            Notify notify = SMS;
            notify += Email;
            notify += Push;

            notify();

            Console.WriteLine("After removing Email:");
            notify -= Email;
            notify();
        }

        public static void SMS()
        {
            Console.WriteLine("SMS Sent");
        }
        public static void Email()
        {
            Console.WriteLine("Email Sent");
        }
        public static void Push()
        {
            Console.WriteLine("Push Notification Sent");
        }
    }
}
