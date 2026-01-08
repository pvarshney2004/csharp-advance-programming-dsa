using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Stack
{
    /*
     2. Web Browser Tab Navigation (Back/Forward Tabs)
Use Case: Users can navigate back and forward between opened tabs.
OOP Concepts:
● Interface: NavigationManager
● Encapsulation: Two stacks handle navigation state.
● Polymorphism: Could extend for mobile vs desktop browser.
     */
    // interface
    interface INavigationManager
    {
        void OpenTab(string url);
        void GoBack();
        void GoForward();
        void CurrentTab();
    }
    // class implementing methods for navigation manager
    internal class NavigationTab : INavigationManager
    {
        Stack<string> forward = new Stack<string>();
        Stack<string> back = new Stack<string>();
        string current = null;
        public void OpenTab(string url)
        {
            if (current != null)
            {
                back.Push(current);
            }
            current = url;
            forward.Clear();
            Console.WriteLine("Current tab: " + current);
        }

        public void GoBack()
        {
            if(back.Count == 0)
            {
                Console.WriteLine("No tabs available");
                return;
            }
            forward.Push(current);
            current = back.Pop();
            Console.WriteLine("Back to tab: " + current);
        }

        public void GoForward()
        {
            if(forward.Count == 0)
            {
                Console.WriteLine("No tabs available");
                return;
            }
            back.Push(current);
            current = forward.Pop();
            Console.WriteLine("Forwarded to tab: " + current);
        }

        public void CurrentTab()
        {
            Console.WriteLine("Current Tab: " + current);
        }
    }
}
