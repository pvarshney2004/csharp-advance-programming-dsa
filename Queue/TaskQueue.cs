using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Queue
{
    /*
     3.Task Dispatcher for Background Workers
Use Case: Queue tasks like file uploads, analytics, or logs to background workers.
OOP Concepts:
● Interface: BackgroundTask
● Encapsulation: TaskQueue shields queue logic.
● Polymorphism: Different tasks (upload, report) use same interface.
     */
    // interface
    interface IBackgroundTask
    {
        void DispatchTask();
    }

    // subclasses implementing DispatchTask method of interface
    class UploadTask : IBackgroundTask
    {
        public void DispatchTask()
        {
            Console.WriteLine("Upload task dispatched");
        }
    }
    class ReportTask : IBackgroundTask
    {
        public void DispatchTask()
        {
            Console.WriteLine("Report task dispatched");
        }
    }

    // class TaskQueue handling tasks
    internal class TaskQueue
    {
        Queue<IBackgroundTask> q = new Queue<IBackgroundTask>();
        public void AddTask(IBackgroundTask task)
        {
            q.Enqueue(task);
        }

        public void DispatchTask()
        {
            if (q.Count > 0)
            {
                q.Dequeue().DispatchTask();
            }
            else
            {
                Console.WriteLine("No task available for dispatching.");
            }
        }
    }
}
