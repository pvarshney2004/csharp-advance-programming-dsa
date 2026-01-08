using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Queue
{
    /*
     2. Ticket Booking System Queue
Use Case: Ticket requests (flight, train) are processed in sequence.
OOP Concepts:
● Interface: TicketRequest
● Encapsulation: Request queue managed inside a service.
● Abstraction & Polymorphism: Works for bus/train/flight with common interface.
     */
    // interface
    interface ITicketRequest
    {
        void BookTicket();
    }
     // subclass implementing BookTicket method of interface
    class FlightTicket : ITicketRequest
    {
        public void BookTicket()
        {
            Console.WriteLine("Flight ticket booked.");
        }
    }
    class BusTicket : ITicketRequest
    {
        public void BookTicket()
        {
            Console.WriteLine("Bus ticket booked.");
        }
    }
    class TrainTicket : ITicketRequest
    {
        public void BookTicket()
        {
            Console.WriteLine("Train ticket booked.");
        }
    }
    // class BookingQueue for handling ticket request
    internal class BookingQueue
    {
        Queue<ITicketRequest> q = new Queue<ITicketRequest>();
        public void AddRequest(ITicketRequest bookingRequest)
        {
            q.Enqueue(bookingRequest);
        }

        public void BookNext()
        {
            if (q.Count > 0)
            {
                q.Dequeue().BookTicket();
            }
            else
            {
                Console.WriteLine("No request available for ticket booking.");
            }
        }
    }
}
