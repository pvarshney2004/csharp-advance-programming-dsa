using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Linked_List
{
    /*
     Scenario 13: Customer Support Chat Queue System
Use Case: Customers are put in a queue to chat with the next available agent.
Why LinkedList? FIFO nature helps maintain order of service.
OOP Concepts:
● Interface: UserRequest for any type of request (chat, call, email).
● Polymorphism: Different request types handled uniformly.
● Encapsulation: Request queue is managed privately.
● Abstraction: Simple API to add/request service.
     */
    // interface
    interface IUserRequest
    {
        void Handle();
    }

    // diffrent subclasses implementing IUserRequest that contains method for handling request
    class ChatRequest : IUserRequest
    {
        public void Handle()
        {
            Console.WriteLine("Chat request handled.");
        }
    }
    class CallRequest : IUserRequest
    {
        public void Handle()
        {
            Console.WriteLine("Call request handled.");
        }
    }
    class EmailRequest : IUserRequest
    {
        public void Handle()
        {
            Console.WriteLine("Email request handled.");
        }
    }

    // node class
    class Node
    {
        public IUserRequest req;
        public Node Next;
        public Node(IUserRequest req)
        {
            this.req = req;
            Next = null;
        }
    }
    // SupportQueue class 
    internal class SupportQueue
    {
        private Node head;
        private Node tail;

        // method to add new request to the queue
        public void AddRequestInQueue(IUserRequest req)
        {
            Node n = new Node(req);
            if (head == null)
            {
                head = tail = n;
            }
            else
            {
                tail.Next = n;
                tail = n;
            }
            Console.WriteLine("New request added in the queue.");
        }
        // handling next request in the queue
        public void CallNextRequest()
        {
            if (head == null)
            {
                Console.WriteLine("No pending request available.");
                return;
            }
            head.req.Handle();
            head = head.Next;
        }
    }
}
