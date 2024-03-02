using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassStruct
{
    internal class Adrress
    {
        public string street { get; private set; }
        public string city { get; private set; }
        public string state { get; private set; }
        public string zipcode { get; private set; }

        public void SetAddress(string Street, string City, string State, string ZipCode)
        {
            street = Street;
            city = City;
            state = State;
            zipcode = ZipCode;
            string Address = $"{street},{city},{state},{zipcode}";
            Console.WriteLine(Address);
        }

        //Using Constructor
        public Adrress(string Street, string City, string State, string ZipCode)
        {
            // Validate street
            if (string.IsNullOrWhiteSpace(Street))
            {
                throw new ArgumentException("Street cannot be empty or whitespace.");
            }

            // Validate city
            if (string.IsNullOrWhiteSpace(City))
            {
                throw new ArgumentException("City cannot be empty or whitespace.");
            }

            // Validate state (example: check length)
            if (State.Length != 2)
            {
                throw new ArgumentException("State must be a two-letter abbreviation.");
            }

            // Validate zipcode (example: check length and pattern)
        
                        if (!Regex.IsMatch(ZipCode, "^[0-9]{5}$"))

            {
                throw new ArgumentException("Zipcode must be a 5-digit number.");
            }



            street = Street;
            city = City;
            state = State;
            zipcode = ZipCode;
        }

        public string FullAddress
        {
            get
            {
                return $"{street},{city},{state},{zipcode}";
            }

        }
        public Adrress()
        {
                
        }
    }
}



using ClassStruct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------H.W----------------------------");
            Console.WriteLine("---PART#1----Without Constructor");
            Adrress addr = new Adrress();
            addr.SetAddress("123 BushTown", "ForeNoire", "MontFlueri", "Box485");

            Console.WriteLine("-------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("---PART#2----With Constructor");
            Adrress addr2 = new Adrress("345 Mont","Goat City","MF","68791");
            Console.WriteLine(addr2.FullAddress);


            Console.WriteLine();
            PersonModel person = new PersonModel("KalbiCtor");
            person.FirstName = "Neville";


            //person.LastName = "Rusteau";
            //LastName Set with Cconstructor
            Console.WriteLine(person.FullName);

            //LastName set with a Method
            person.SetLastName("Kalebi");
            Console.WriteLine( person.FullName);

            person.Age = 16;
            person.SSN = "123_45_98765";

            Console.WriteLine(person.SSN);
            //Console.WriteLine(person.FirstName + " " + person.LastName);

            //prop with only set accessor
            Console.WriteLine($"Password:  {person.Password=124}");
            Console.WriteLine(person.Password);
            Console.ReadLine();
        }

    }

}
