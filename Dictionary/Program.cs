using System;
namespace Advance_Programming_DSA.Dictionary
{
    class Program
    {
        public static void Main(string[] args)
        {
            //InventoryManager manager = new InventoryManager();
            //manager.Add(101, new Electronics());
            //manager.Add(102, new Clothing());
            //manager.Get(101).ShowDetails();
            //manager.Get(102).ShowDetails();

            //AuthSystem auth = new AuthSystem();
            //auth.AssignRole("admin1", new Admin());
            //auth.AssignRole("user1", new User());
            //Console.WriteLine(auth.HasAccess("admin1", "DELETE")); 
            //Console.WriteLine(auth.HasAccess("user1", "DELETE"));  
            //Console.WriteLine(auth.HasAccess("user1", "READ"));  

            //GradeBook g = new GradeBook();
            //g.AddStudent("pv", new CBSE());
            //g.AddStudent("pv2", new GPA());
            //g.ShowGrade("pv", 91);
            //g.ShowGrade("pv2", 89);

            IURLStorage storage = new MemoryStorage();
            storage.Save("bridge.com", "https://bridgelabz.com");
            Console.WriteLine(storage.Get("bridge.com"));


        }
    }
}