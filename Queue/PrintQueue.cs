using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Queue
{
    /*
     1. Print Job Manager
Use Case: Print requests are handled in the order they are received.
OOP Concepts:
● Interface: Printable
● Encapsulation: PrintQueue class hides internal state.
● Polymorphism: Could be TextDocument, ImageFile, etc
     */
    // interface
    interface IPrintable 
    {
        void Print();
    }
    // subclasses implementing Print method of interface
    class TextDocument : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing text document");
        }
    }

    class ImageFile : IPrintable
    {
        public void Print()
        {
            Console.WriteLine("Printing image file");
        }
    }
    // class PrintQueue that handle printing tasks
    internal class PrintQueue
    {
        Queue<IPrintable> q = new Queue<IPrintable>();
        public void AddJob(IPrintable job)
        {
            q.Enqueue(job);
        }

        public void PrintNext()
        {
            if (q.Count > 0)
            {
                q.Dequeue().Print();
            }
            else
            {
                Console.WriteLine("No printing task");
            }
        }
    }
}
