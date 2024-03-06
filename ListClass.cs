using System;
using System.Collections.Generic;
using System.Windows.Documents;
using ConsoleNameSpace.Models;
using FoundationInfo;

namespace ConsoleNameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>();
            PersonModel person = new PersonModel
            {
                FirstName = "Neville",
                LastName = "Rusteau",
            };
            
            // Add the person object to the list:
            people.Add(person);

            foreach(PersonModel p  in people)
            {
                Console.WriteLine(p.FirstName + p.LastName);
            }
            for(int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(people[i].FirstName + people[i].LastName);
            }

            people.Clear();

            foreach (PersonModel p in people)
            {
                Console.WriteLine(p.FirstName + ", " + p.LastName);
            }


            double sum = Calculations.Add(2.5, 3.4);
           Console.WriteLine();
        }
    }
}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleNameSpace.Models
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    } 
}
 