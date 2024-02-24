//HOW TO USE CLASS WITH LISAT 
//OWN CLASS 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OwnType
{
    internal class Program
    {
        static void Main(string[] args)
        {



            string importString = "Jan Report;The First Report;123;" +
                "Feb Report;The Second Report;456;" +
                "March Report;The Third Report;890";

            List<Report> reportList = new List<Report>();
            string[] parts = importString.Split(';');
            for (int i = 0; i < parts.Length; i += 3) //Process in set of 3
            {
                Report report = new Report();
                report.Title = parts[i];
                report.Description = parts[i + 1];
                report.Number = Convert.ToInt32(parts[i + 2]);
                reportList.Add(report);
            }
            foreach (var report in reportList)
            {
                Console.WriteLine(report.Title);
                Console.WriteLine(report.Number);
                Console.WriteLine(report.Display());
            }
 /*  you can very easily make as many objects
as we need adding the objects to the report
objects to this generic collection which
holds the objects */

            //foreach (string part in parts)
            //{
            //    reportList.Add(new Report());
            //}
            //foreach (string part in parts)
            //{
            //    Console.WriteLine(part);
            //}



        }

        public class Report
        {
            public string Title { get; set; }
            public string Description { get; set; }
            public int Number { get; set; }

            internal string Display()
            {
                if (Number > 300)
                    return $"{Title},{Description},pp: {Number} (LONG REPORT)";
                else
                    return $"{Title},{Description},pp: {Number}";
            }
        }
    }


}
