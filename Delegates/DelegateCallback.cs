using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Delegates
{
    /*
    Callback using Delegate
Simulate a file download method that accepts a delegate as a callback to notify when download completes. 
     */
    public delegate void DownloadCallback(string message);
    internal class DelegateCallback
    {
        public static void DownloadFile(DownloadCallback callback)
        {
            Console.WriteLine("Downloading file...");
            Thread.Sleep(2000);
            callback("Download completed successfully!");
        }
        // callback method
        public static void OnDownloadCompleted(String msg)
        {
            Console.WriteLine(msg);
        }
    }
}
