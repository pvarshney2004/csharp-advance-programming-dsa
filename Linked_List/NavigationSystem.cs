using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    /*
     Scenario 1: Browser History Navigation
Use Case: Maintain a user’s browsing history with the ability to move back and forth.
Why LinkedList? Doubly linked list makes it easy to navigate both backward and forward.
OOP Concepts:
● Encapsulation: Browser history data is wrapped inside a class.
● Abstraction: Navigation methods hide internal implementation.
● Inheritance & Polymorphism: Reusable navigation for other apps like music players.
     */
    // Node class representing each page in the history
    class Node
    {
        public string Url;
        public Node Prev;
        public Node Next;
        public Node(string url)
        {
            Url = url;
            Prev = null;
            Next = null;
        }
    }
    // Abstract base class for navigation system
    abstract class NavigationSystem
    {
        protected Node current;
        public abstract void Visit(string url);
        public virtual void Back()
        {
            if (current != null && current.Prev != null)
            {
                current = current.Prev;
                Console.WriteLine("Navigated Back to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No previous page available.");
            }
        }
        public virtual void Forward()
        {
            if (current != null && current.Next != null)
            {
                current = current.Next;
                Console.WriteLine("Navigated Forward to: " + current.Url);
            }
            else
            {
                Console.WriteLine("No next page available.");
            }
        }
    }
    // Subclass implementing the browser history navigation
    class BrowserHistory : NavigationSystem
    {
        public override void Visit(string url)
        {
            Node newNode = new Node(url);
            if (current != null)
            {
                current.Next = newNode;
                newNode.Prev = current;
            }
            current = newNode;
            Console.WriteLine("Visited to: " + current.Url);
        }
    }
}
