using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advance_Programming_DSA.Dictionary
{
    /*
     3.Student Grade Book
Use Case: Map student roll numbers to their grade report.
OOP Concepts:
● Interface: GradeReport
● Polymorphism: Different grading strategies (CBSE, GPA).
● Encapsulation: Grade map managed inside grade service.
     */
    // interface
    interface IGradeReport
    {
        string GetGrade(int marks);
    }

    // subclasses
    class CBSE : IGradeReport
    {
        public string GetGrade(int marks)
        {
            return marks >= 90 ? "A" : "B";
        }
    }
    class GPA : IGradeReport
    {
        public string GetGrade(int marks)
        {
            return marks >= 90 ? "9.0" : "8.0";
        }
    }

    // class GradeBook handling mapping of student and report
    internal class GradeBook
    {
        Dictionary<string, IGradeReport> gr = new Dictionary<string, IGradeReport>();

        public void AddStudent(string name, IGradeReport report)
        {
            gr[name] = report;
        }

        public void ShowGrade(string name, int marks)
        {
            Console.WriteLine($"Grade of {name}: " + gr[name].GetGrade(marks));
        }
    }
}
