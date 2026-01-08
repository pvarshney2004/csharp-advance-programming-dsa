using System;
namespace Advance_Programming_DSA.Queue
{
    class Program
    {
        public static void Main(string[] args)
        {
            //PrintQueue pq = new PrintQueue();
            //pq.AddJob(new TextDocument());
            //pq.AddJob(new ImageFile());
            //pq.PrintNext();
            //pq.PrintNext();
            //pq.PrintNext();


            //BookingQueue bq = new BookingQueue();
            //bq.AddRequest(new FlightTicket());
            //bq.AddRequest(new TrainTicket());
            //bq.AddRequest(new BusTicket());
            //bq.BookNext();
            //bq.BookNext();
            //bq.BookNext();
            //bq.BookNext();


            //TaskQueue tq = new TaskQueue();
            //tq.AddTask(new UploadTask());
            //tq.AddTask(new ReportTask());
            //tq.AddTask(new UploadTask());
            //tq.DispatchTask();
            //tq.DispatchTask();
            //tq.DispatchTask();
            //tq.DispatchTask();


            CallCenterQueue cq = new CallCenterQueue();
            cq.AddRequest(new SupportCall());
            cq.AddRequest(new SalesCall());
            cq.AddRequest(new SupportCall());
            cq.HandleNext();
            cq.HandleNext();
            cq.HandleNext();
            cq.HandleNext();



        }
    }
}