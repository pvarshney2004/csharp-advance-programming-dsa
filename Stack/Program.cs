using System;
namespace Advance_Programming_DSA.Stack
{
    class Program
    {
        public static void Main(string[] args)
        {
            //InfixToPostfix obj = new InfixToPostfix();
            //Console.WriteLine("Give infix notation: ");
            //string? infix = Console.ReadLine();
            //string postfix = obj.Convert(infix);
            //PostfixEvaluator evaluator = new PostfixEvaluator();
            //int result = evaluator.Evaluate(postfix);
            //Console.WriteLine($"Infix Notation: {infix}");
            //Console.WriteLine($"Postfix Notation: {postfix}");
            //Console.WriteLine($"Result: {result}");

            //NavigationTab obj2 = new NavigationTab();
            //obj2.OpenTab("google.com");
            //obj2.OpenTab("github.com");
            //obj2.OpenTab("stackoverflow.com");
            //obj2.GoBack();
            //obj2.GoBack();
            //obj2.GoForward();
            //obj2.CurrentTab();

            //CheckSyntax obj3 = new CheckSyntax();
            //Console.WriteLine("Give parentheses notation: ");
            //string? str = Console.ReadLine();
            //bool result = obj3.IsValid(str);
            //if (result)
            //{
            //    Console.WriteLine(str + " is valid.");
            //}
            //else
            //{
            //    Console.WriteLine(str + " is not valid.");
            //}

            DrawingApp app = new DrawingApp();
            app.PerformAction(new DrawLine());
            app.PerformAction(new DrawCircle());
            app.PerformAction(new Erase());
            app.Undo();
            app.Undo();

        }
    }
}