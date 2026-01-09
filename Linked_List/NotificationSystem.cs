using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Linked_List
{
    /*
     10: Custom Notification System with Interface and LinkedList
Use Case: Deliver notifications of different types (Email, SMS, Push) and store them in a
delivery queue.
OOP Concepts:
● Interface: Notification interface represents all types.
● Polymorphism: Each notification type handles delivery differently.
● Encapsulation: NotificationQueue hides internal structure.
● Abstraction: Only add() and sendAll() methods are exposed.
     */
    // interface
    interface INotification
    {
        void SendNotification();
    }

    // subclasses implementing INotification interface that contains method for Sending notification
    class SMSNotification : INotification
    {
        public void SendNotification()
        {
            Console.WriteLine("Sending SMS Notification");
        }
    }

    class OTPNotification : INotification
    {
        public void SendNotification()
        {
            Console.WriteLine("Sending OTP Notification");
        }
    }
    class NewsNotification : INotification 
    {
        public void SendNotification()
        {
            Console.WriteLine("Sending News Notification");
        }
    }
    // node class
    class Node1
    {
        public INotification notification;
        public Node1 Next;
        public Node1(INotification notification)
        {
            this.notification = notification;
            Next = null;
        }
    }
    // class demonstrating notifictaion queue
    internal class NotificationSystem
    {
        private Node1 head;
        private Node1 tail;

        public void AddNotification(INotification notification)
        {
            Node1 nn = new Node1(notification);
            if (head == null)
            {
                head = tail= nn;
            }
            else
            {
                tail.Next = nn;
                tail = nn;
            }
        }

        public void SendAll()
        {
            Node1 curr = head;
            while (curr != null)
            {
                curr.notification.SendNotification();
                curr = curr.Next;
            }
        }
    }
}
