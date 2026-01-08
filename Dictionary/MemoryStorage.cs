using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Dictionary
{
    /*
    4.URL Shortener Service
Use Case: Map short URLs to long URLs.
OOP Concepts:
● Interface: URLStorage
● Abstraction & Encapsulation: Only get/put methods exposed.
● Polymorphism: Can implement with memory, DB, file-based storage. 
    */
    // interface
    interface IURLStorage
    {
        void Save(string shortUrl, string longUrl);
        string Get(string shortUrl);
    }

    // subclass
    class MemoryStorage : IURLStorage
    {
        Dictionary<string, string> urls = new Dictionary<string, string>();
        public void Save(string shortUrl, string longUrl)
        {
            urls[shortUrl] = longUrl;
        }

        public string Get(string shortUrl)
        {
            return urls.ContainsKey(shortUrl) ? urls[shortUrl] : "Not Found in database";
        }
    }
}
