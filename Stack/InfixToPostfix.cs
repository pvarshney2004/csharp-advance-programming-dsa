using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Stack
{
    /*
     1. Expression Evaluation Engine (Infix to Postfix + Evaluation)
Use Case: Parse and evaluate mathematical expressions in calculators or compilers.
OOP Concepts:
● Interface: ExpressionEvaluator
● Encapsulation: Stack operations hidden inside evaluator.
● Polymorphism: Different strategies like PostfixEvaluator, PrefixEvaluator.
     */
    // interface 
    interface IExpressionEvaluator
    {
        int Evaluate(string expression);
    }
    // class implementing interface for postfix evaluation
    class PostfixEvaluator : IExpressionEvaluator
    {
        public int Evaluate(string expression)
        {
            Stack<int> stack = new Stack<int>();
            foreach (char ch in expression)
            {
                if (char.IsDigit(ch))
                {
                    stack.Push(ch - '0'); // converting char to int
                }
                else
                {
                    int b = stack.Pop();
                    int a = stack.Pop();
                    switch (ch)
                    {
                        case '+': stack.Push(a + b); break;
                        case '-': stack.Push(a - b); break;
                        case '*': stack.Push(a * b); break;
                        case '/': stack.Push(a / b); break;
                    }
                }
            }
            return stack.Pop();
        }
    }
    // class contains method for infix to postfix conversion
    internal class InfixToPostfix
    {
        public int CheckPrecedence(char ch)
        {
            if (ch == '*' || ch == '/') return 2;
            if (ch == '+' || ch == '-') return 1;
            return 0;
        }
        public string Convert(string infix)
        {
            Stack<char> stack = new Stack<char>();
            string postfix = "";
            foreach(char ch in infix)
            {
                if (char.IsDigit(ch))
                {
                    postfix += ch;
                }
                else if (ch == '(')
                {
                    stack.Push(ch);
                }
                else if (ch == ')')
                {
                    while (stack.Peek() != '(')
                    {
                        postfix += stack.Pop();
                    }
                    stack.Pop();
                }
                else
                {
                    while (stack.Count > 0 && CheckPrecedence(stack.Peek()) >= CheckPrecedence(ch))
                    {
                        postfix += stack.Pop();
                    }
                    stack.Push(ch);
                }
            }
            while (stack.Count > 0)
            {
                postfix += stack.Pop();
            }
            return postfix;
        }
    }
}
