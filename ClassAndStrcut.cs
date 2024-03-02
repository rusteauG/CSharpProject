// Diff between  pass by valk and Ref , Class are ref vals and created in Heap, with a ref pointer pointing to them on the stack
//Primitive val like struc are pass by val, a new copy is creaetd when passed

using System;


namespace ClassStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Report report = new Report()
            {
                Title = "Hunger Games 2012",
                Description = "First Movie in ther Series",
                Pages = 100,
            };
            report.Display(); //100pg

            //the ref is copied into report2 points to tha same class, 
            Report report2 = report;
            report2.Display(); //100pg

            report2.Pages = 200;
            report2.Display();  //200pg
            report.Display();  //200pg  

            ReportStruct reportStruc = new ReportStruct()
            {
                Title = "Hunger Games Catching Fire Part1",
                Description = "Second Movie in ther Series",
                Pages = 400,
            };


            reportStruc.Display();
            //a new Copy is created in the Stack, Pass by Value for primitivwe vals
            ReportStruct reportStruc2 = reportStruc;
            reportStruc2.Pages = 200;
            reportStruc2.Display();  //200pg
            reportStruc.Display();  //400pg

        }

        public class Report
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public int Pages { get; set; }

            public void Display()
            {
                Console.WriteLine(String.Format("{0} : {1} : {2}pg", Title, Description, Pages));
            }
        }


        public struct ReportStruct
        {

            public string Title { get; set; }
            public string Description { get; set; }
            public int Pages { get; set; }

            public void Display()
            {
                Console.WriteLine(String.Format("{0} : {1} : {2}pg", Title, Description, Pages));
            }
        }
    }

}
