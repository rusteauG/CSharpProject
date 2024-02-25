using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> people = new List<PersonModel>();
            string firstName = String.Empty;
            string lastName = String.Empty;
            string emailAddress = String.Empty;

            while (true)
            {

                firstName = GetInput("What is your FirstName (or type exit to Quit): ");
                if (firstName.ToLower() == "exit")
                {
                    break;
                }
                lastName = GetInput("What is your LastName (or type exit to Quit): ");

                if (lastName.ToLower() == "exit")
                { break; }


                while (true) // Inner loop for email validation
                {
                    emailAddress = GetInput("What is your email (or type exit to Quit): ");

                    if (emailAddress.ToLower() == "exit")
                    {
                        break;
                    }

                    if (!IsValidEmail(emailAddress))
                    {
                        Console.WriteLine("Invalid email format. Please try again.");

                    }
                    else
                    {
                        break; // Valid email, exit the inner loop

                    }
                }

                if (emailAddress.ToLower() == "exit")
                {
                    break; // Exit the outer loop if "exit" was entered for email
                }

                PersonModel person = new PersonModel();
                person.FirstName = firstName;
                person.LastName = lastName;
                person.EmailAddress = emailAddress;
                people.Add(person);


            };
            Console.WriteLine("\nList of People:");

            foreach (PersonModel person in people)
            {
                Console.WriteLine($"{person.FirstName},{person.LastName},Email:{person.EmailAddress} ");
            }









            //List<PersonModel> people = new List<PersonModel>();

            //PersonModel person = new PersonModel();
            //person.fristName = "Neville";
            //people.Add(person);

            //person = new PersonModel();
            //person.fristName = "Tim";
            //people.Add(person);

            //foreach (PersonModel p in people)
            //{
            //    Console.WriteLine(p.fristName);
            //}     


            Console.WriteLine();
        }
        private static string GetInput(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().Trim();
        }
        private static bool IsValidEmail(string emailAddress)
        {
            const string emailPattern = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*";

            // Implement your email validation logic here
            bool ValidEmail = Regex.IsMatch(emailAddress, emailPattern);

            return ValidEmail; // Placeholder for real validation
        }
    }
}





//Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class PersonModel
    {
        //auto Property
        public string FirstName { get; set; }
        public string EmailAddress { get; set; }
        public string LastName { get; set; }    

        //public string fristName;
        //public string lastName;
        //public string emailAddress;
    }
}
