using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Stack
{
    /*
     4.Undo Functionality in Drawing App
Use Case: Maintain stack of actions (line drawn, shape added) and support undo.
OOP Concepts:
● Interface: DrawingAction
● Polymorphism: Multiple actions (line, circle, erase) handled uniformly.
● Encapsulation: Undo stack wrapped inside the app logic
     */
    interface IDrawingAction
    {
        void Undo();
    }
    // subclasses implementing IDrawingAction interface 
    class DrawLine : IDrawingAction
    {
        public void Undo()
        {
            Console.WriteLine("Undo Line Drawing");
        }
    }

    class DrawCircle : IDrawingAction
    {
        public void Undo()
        {
            Console.WriteLine("Undo Circle Drawing");
        }
    }

    class Erase : IDrawingAction
    {
        public void Undo()
        {
            Console.WriteLine("Undo Erase Action");
        }
    }

    internal class DrawingApp
    {
        // stack of actions
        Stack<IDrawingAction> st = new Stack<IDrawingAction>();
        public void PerformAction(IDrawingAction action)
        {
            st.Push(action);
            Console.WriteLine("Action performed");
        }
        public void Undo()
        {
            if (st.Count > 0)
            {
                IDrawingAction action = st.Pop();
                action.Undo();
            }
            else
                Console.WriteLine("Nothing to undo");
        }
    }
}
