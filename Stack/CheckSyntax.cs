using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Stack
{
    /*
     3.Syntax Checker for Code Editors
Use Case: Validate matched parentheses, brackets, or braces ({}, [], ()).
OOP Concepts:
● Interface: SyntaxChecker
● Encapsulation: Stack logic is hidden inside the implementation.
● Polymorphism: Can create multiple syntax checkers for different file types
     */
    interface ISyntaxChecker
    {
        bool IsValid(string str);
    }
    internal class CheckSyntax : ISyntaxChecker
    {
        // method to check parentheses is valid or not
        public bool IsValid(string str)
        {
            Stack<char> st = new Stack<char>();
            foreach (char ch in st)
            {
                if (ch == '(' && !(st.Count == 0) && st.Peek() == '(')
                {
                    st.Pop();
                }
                else if (ch == ']' && !(st.Count==0) && st.Peek() == '[')
                {
                    st.Pop();
                }
                else if (ch == '}' && !(st.Count==0) && st.Peek() == '{')
                {
                    st.Pop();
                }
                else
                {
                    st.Push(ch);
                }
            }
            return st.Count == 0;
        }
    }
}
