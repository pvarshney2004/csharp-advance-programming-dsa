using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Linked_List
{
    /*
     Scenario 9: Undo/Redo Manager with Interface-Based Command Pattern
Use Case: Implement an undo/redo manager for operations like typing, deleting, or
formatting in a document editor.
Why LinkedList? Acts as a stack for undo and redo operations.
OOP Concepts:
● Interface: Each command implements a common Command interface.
● Polymorphism: Same execute() and undo() method works for different
operations.
● Encapsulation & Abstraction: User doesn’t see the inner workings of the
command queue.
     */

    // interface
    interface ICommand
    {
        void Execute();
        void Undo();
    }
    // subclasses implementing ICommand interface that contains method for execute and undo command
    class WriteCommand : ICommand
    {
        public void Execute() 
        {
            Console.WriteLine("Writing text");
        }
        public void Undo()
        {
            Console.WriteLine("Undo writing");
        }
    }
    class DeleteCommand : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Deleting text");
        }
        public void Undo()
        {
            Console.WriteLine("Undo delete");
        }
    }

    // node class
    class CommandNode
    {
        public ICommand cmd;
        public CommandNode Next;
        public CommandNode(ICommand cmd)
        {
            this.cmd = cmd;
            Next = null;
        }

    }
    internal class UndoRedoManager
    {
        Stack<ICommand> undo = new Stack<ICommand>();
        Stack<ICommand> redo = new Stack<ICommand>();

        public void Do(ICommand cmd)
        {
            cmd.Execute(); // executing command
            undo.Push(cmd); // pushing executed command to undo stack
        }

        public void Undo()
        {
            ICommand cmd = undo.Pop();
            if (cmd == null)
            {
                Console.WriteLine("Nothing to undo");
                return;
            }
            cmd.Undo();
            redo.Push(cmd); // pushing undo command into redo stack 
        }

        public void Redo()
        {
            ICommand cmd = redo.Pop();
            if (cmd == null)
            {
                Console.WriteLine("Nothing to redo");
                return;
            }
            cmd.Execute();
            undo.Push(cmd); // pushing redo command to undo stack
        }
    }
}