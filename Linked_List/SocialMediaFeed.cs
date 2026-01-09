using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Linked_List
{
    /*
     Scenario 7: Social Media Notification Feed
Use Case: Store and display recent notifications for a user in reverse chronological order
(most recent first).
Why LinkedList? Fast insert at the beginning and sequential traversal.
OOP Concepts:
● Encapsulation: User feed is managed privately.
● Abstraction: API-style access to addNotification() and displayFeed().
● Inheritance/Polymorphism: Different types of notifications (LikeNotification,
CommentNotification) can be handled generically.
     */
    // abstract class containing abstract method Show()
    abstract class Notification
    {
        public abstract void Show();
    }

    // child class inheriting Notification class
    class LikeNotification : Notification
    {
        public override void Show()
        {
            Console.WriteLine("user liked your post.");
        }
    }
    class CommentNotification : Notification
    {
        public override void Show()
        {
            Console.WriteLine("user commented on your post.");
        }
    }
    // class node
    class SNode
    {
        public Notification Data;
        public SNode Next;
        public SNode(Notification n)
        {
            Data = n;
            Next = null;
        }
    }
    internal class SocialMediaFeed
    {
        private SNode head;

        // adding notification at beginning (add first at linked list method)
        public void AddNotification(Notification n)
        {
            SNode nn = new SNode(n);
            nn.Next = head;
            head = nn;
        }
        // displaying notifications
        public void Displayfeed()
        {
            SNode curr = head;
            while (curr != null)
            {
                curr.Data.Show();
                curr = curr.Next;
            }
        }
    }
}
