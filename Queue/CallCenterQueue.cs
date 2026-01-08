using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Queue
{
    /*
     4.Call Center Management System
Use Case: Incoming calls are queued for available agents.
OOP Concepts:
● Interface: CallRequest
● Polymorphism: Calls could be SupportCall, SalesCall, etc.
● Encapsulation: Queue handling hidden inside CallCenterManager
     */
    // interface
    interface ICallRequest
    {
        void CallingRequest();
    }

    // subclass implementing CallingRequest method of interface
    class SupportCall : ICallRequest
    {
        public void CallingRequest()
        {
            Console.WriteLine("Support call request received and handled.");
        }
    }
    class SalesCall : ICallRequest
    {
        public void CallingRequest()
        {
            Console.WriteLine("Sales call request received and handled.");
        }
    }

    // class CallCenterQueue that will handle all the incoming calls
    internal class CallCenterQueue
    {
        Queue<ICallRequest> q = new Queue<ICallRequest>();
        public void AddRequest(ICallRequest callRequest)
        {
            q.Enqueue(callRequest);
        }

        public void HandleNext()
        {
            if (q.Count > 0)
            {
                q.Dequeue().CallingRequest();
            }
            else
            {
                Console.WriteLine("No call request available.");
            }
        }
    }
}
