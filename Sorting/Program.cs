using Advance_Programming_DSA.Sorting;
using System;
namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            //SortMarks obj = new SortMarks();
            //int[] marks = { 45, 23, 34, 76, 50 };
            //Console.WriteLine("Marks before sorting: "+ string.Join(", ",marks));
            //obj.Sort(marks);
            //Console.WriteLine("Marks after sorting: " + string.Join(", ", marks));

            //SortIDs obj2 = new SortIDs();
            //int[] Ids = { 104, 102, 103, 107, 105 };
            //Console.WriteLine("IDs before sorting: "+ string.Join(", ",Ids));
            //obj2.Sort(Ids);
            //Console.WriteLine("IDs after sorting: " + string.Join(", ", Ids));

            //SortPrices obj3 = new SortPrices();
            //int[] prices = { 78, 65, 56, 87, 93, 34, 23 };
            //Console.WriteLine("Prices before sorting: "+ string.Join(", ",prices));
            //int[] ans = obj3.Sort(prices, 0, prices.Length-1);
            //Console.WriteLine("Prices after sorting: " + string.Join(", ", ans));

            //SortScores obj4 = new SortScores();
            //int[] scores = { 78, 56, 34, 89, 73, 95 };
            //Console.WriteLine("Scores before sorting: " + string.Join(", ", scores));
            //obj4.Sort(scores);
            //Console.WriteLine("Scores after sorting: " + string.Join(", ", scores));

            //SortAges obj5 = new SortAges();
            //int[] ages = { 78, 65, 56, 87, 93, 34, 23 };
            //Console.WriteLine("Ages before sorting: " + string.Join(", ", ages));
            //int[] ans = obj5.Sort(ages);
            //Console.WriteLine("Ages after sorting: " + string.Join(", ", ans));

            //SortProductPrices obj6 = new SortProductPrices();
            //int[] prices = { 780, 650, 560, 870, 930, 340, 230 };
            //Console.WriteLine("Prices before sorting: " + string.Join(", ", prices));
            //obj6.Sort(prices,0,prices.Length-1);
            //Console.WriteLine("Prices after sorting: " + string.Join(", ", prices));

            SortSalary obj7 = new SortSalary();
            int[] salaries = { 60000, 65000, 50000, 30000, 70000, 40000 };
            Console.WriteLine("Salaries before sorting: " + string.Join(", ", salaries));
            obj7.Sort(salaries);
            Console.WriteLine("Salaries after sorting: " + string.Join(", ", salaries));
        }
    }
}