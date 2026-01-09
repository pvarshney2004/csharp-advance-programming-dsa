using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Linked_List
{
    /*
     Scenario 4: Customer Service Call Center Queue
Use Case: Handle customer support tickets in order of arrival.
Why LinkedList? FIFO nature can be modeled via a queue using LinkedList.
OOP Concepts:
● Abstraction: Add/remove operations for ticket queue.
● Encapsulation: Each ticket is hidden behind methods.
● Polymorphism: Different ticket types (chat, call, email) handled similarly.
     */
    // abstract class Ticket
    abstract class Ticket
    {
        public abstract void Handle();
    }

    // child classes inheriting Ticket
    class ChatTicket : Ticket
    {
        public override void Handle()
        {
            Console.WriteLine("Chat ticket handled");
        }
    }
    class CallTicket : Ticket
    {
        public override void Handle()
        {
            Console.WriteLine("Call ticket handled");
        }
    }
    class EmailTicket : Ticket
    {
        public override void Handle()
        {
            Console.WriteLine("Email ticket handled");
        }
    }

    // node 
    class TicketNode
    {
        public Ticket t;
        public TicketNode? Next;
        public TicketNode(Ticket t)
        {
            this.t = t;
            Next = null;
        }
    }
    // class handling add/remove support tickets
    internal class CallCenterQueue
    {
        private TicketNode? head;
        private TicketNode? tail;

        public void AddSupportTicket(Ticket t)
        {
            TicketNode nn = new TicketNode(t);
            if (head == null)
            {
                head = tail = nn;
            }
            else
            {
                tail.Next = nn;
                tail = nn;
            }
        }

        public void RemoveSupportTicket()
        {
            if (head == null)
            {
                Console.WriteLine("No support ticket available");
                return;
            }
            head.t.Handle();
            head = head.Next;
        } 

    }
}
