using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Linked_List
{
    /*     
     Train Route Management System
Use Case: A railway system manages stations as linked stops in a train's route. You can
dynamically insert, remove, or reverse the route.
Why LinkedList? Allows dynamic insertion/removal of stations and easy traversal of the route.
OOP Concepts:
● Encapsulation: Each route is encapsulated in its own class.
● Abstraction: Public methods like addStation(), removeStation() hide internal
pointer logic.
● Inheritance: Could extend Route for special trains (Express, Freight).
● Polymorphism: You can override travel rules for different train types.
     */

    // station node
    class Station
    {
        public string Name;
        public Station Next;
        public Station(string name)
        {
            Name = name;
            Next = null;
        }
    }
    // class implementing route system
    internal class TrainRouteSystem
    {
        protected Station head;
        
        public void AddStationAtLast(string name)
        {
            Station st = new Station(name);
            if (head == null)
            {
                head = st;
            }
            else 
            {
                Station temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = st;
            }
        }

        public void AddStationAtBeginning(string name)
        {
            Station st = new Station(name);
            if (head == null)
            {
                head = st;
            }
            else
            {
                st.Next = head;
                head = st;
            }

        }

        public void RemoveStation(string name)
        {
            if (head == null) return;
            if(head.Name == name)
            {
                head = head.Next;
                return;
            }
            Station curr = head;
            while(curr.Next!=null && curr.Next.Name != name)
            {
                curr = curr.Next;
            }
            if(curr.Next != null)
            {
                curr.Next = curr.Next.Next;
            }
        }
        public virtual void DisplayRoute()
        {
            Station temp = head;
            Console.WriteLine("Train route: ");
            while (temp != null)
            {
                Console.Write(temp.Name + " -> ");
                temp = temp.Next;
            }
            Console.WriteLine("X");
        }

    }
    class ExpressTrainRoute : TrainRouteSystem
    {
        public override void DisplayRoute()
        {
            Station temp = head;
            Console.WriteLine("Express Train Route: ");
            while (temp != null)
            {
                Console.Write(temp.Name + " -> ");
                if (temp.Next != null)
                {
                    temp = temp.Next.Next;  // express train skips one station
                }
                else break;
            }
            Console.WriteLine("X");
        }
    }
}
