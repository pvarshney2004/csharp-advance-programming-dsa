using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Dictionary
{
    /*
     1. Inventory Management System
Use Case: Maintain a mapping of product IDs to product information.
OOP Concepts:
● Interface: Product
● Encapsulation: Inventory manager manages internal map.
● Abstraction: Simple add(), get() interface.
● Polymorphism: Products can be electronics, clothing, etc
     */
    // interface
    interface IProduct
    {
        void ShowDetails();
    }
    // subclasses
    class Electronics : IProduct
    {
        public void ShowDetails()
        {
            Console.WriteLine("Electronics Product details");
        }
    }

    class Clothing : IProduct
    {
        public void ShowDetails()
        {
            Console.WriteLine("Clothing Product details");
        }
    }
    // class handle product mapping
    internal class InventoryManager
    {
        Dictionary<int, IProduct> dict = new Dictionary<int, IProduct>();
        public void Add(int id, IProduct p)
        {
            dict[id] = p;
        }
        public IProduct Get(int id)
        {
            return dict.ContainsKey(id) ? dict[id] : null;
        }
    }
}
