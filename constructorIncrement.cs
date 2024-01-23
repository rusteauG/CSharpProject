using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class GradeBookTest
    {
        public string CourseName {  get; set; }

        // Static variable to track total courses
        public static int courseTotal = 0;//Intialize to 0

        //Constructor
        public GradeBookTest(string name) { 
            CourseName = name;
            courseTotal++;//Increment count directly within the constructor
        }
        //
        public static void ShowTotal()
        { Console.WriteLine("There are currently "+courseTotal+ " Courses"); }
        public void DisplayMessage()
        {
            Console.WriteLine("Welcome to the GradeBook for\n{0}!",CourseName);
        }
    }
}

----------------------------------------------
using GradeBook;
internal class Program
{
    private static void Main(string[] args)
    {
        GradeBookTest gradeBook1 = new GradeBookTest(
            "CS101 Introduction to C# Programming");
        GradeBookTest gradeBook2 = new GradeBookTest(
            "CS102 Introduction to Data Structure in C#");
        Console.WriteLine("GradeBook1 CourseName: {0}",gradeBook1.CourseName);
        Console.WriteLine("GradeBook2 CourseName: {0}", gradeBook2.CourseName);
        GradeBookTest.ShowTotal();
    }
}