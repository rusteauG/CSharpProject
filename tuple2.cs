//Tuple Eg #2
using ConsoleTuple;
//Console.Write("Enter UserName: ");
//string name = ConsoleMessages.GetUserName();

////Get two Values from method #1 in array  from string with a delim char sep
//string[] output = ConsoleMessages.GetFullName().Split(',');


//for (int i = 0; i < output.Length; i++)
//{ Console.WriteLine(output[i]); }

//method#2 get multiples values using tuples
//(string, string) fullname =
//var fullname = ConsoleMessages.GetFullNameT();
//Console.WriteLine($"Fname: {fullname.Item1}");
//(string fName,string lName ) fullname =  ConsoleMessages.GetFullNameT();
//Console.WriteLine(fullname.lName);
//Console.WriteLine(fullname.fName);

//ShortCut
//(string firstName, string lastName) = ConsoleMessages.GetFullNameT();
//Console.WriteLine($"{firstName}");

////Discard Char - if we dont want to capture sec var use _
////We ignore one of the return type, not using it
//(string firstName, _) = ConsoleMessages.GetFullNameT();
//Console.WriteLine($"{firstName}");

ConsoleMessages.TupleExample();
Console.WriteLine();
(string address, bool Isvalid)  = ConsoleMessages.ValidateString("123. Seasamee st");
if(Isvalid)
{
    Console.WriteLine($"Your Validated address is  :{address}");

}
else
{
    Console.WriteLine($"That is an invaid address: {address} : {Isvalid}");
}



///class


using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTuple
{
    internal class ConsoleMessages
    {
        public static string GetUserName()
        {
            string? name = String.Empty;
            name = Console.ReadLine();
            if (String.IsNullOrEmpty(name))
            {
                do
                {
                    Console.Write("Value Wrong Enter Again: ");
                    name = Console.ReadLine();
                } while (String.IsNullOrEmpty(name));
            }
            return name;
        }

        public static string GetFullName()
        {
            Console.Write("Whats Your FirstName: ");
            string firstName = Console.ReadLine()!;
            Console.Write("Whats Your LasttName: ");
            string lastName = Console.ReadLine()!;

            return firstName + "," + lastName;
        }

        //Tuple
        public static (string firstName, string LastName) GetFullNameT()
        {
            Console.Write("Whats Your FirstName: ");
            string firstName = Console.ReadLine()!;
            Console.Write("Whats Your LasttName: ");
            string lastName = Console.ReadLine()!;

            return (firstName, lastName);
        }

        public static void TupleExample()
        {
            (bool, int) t1 = (true, 3);
            Console.Write($"the first element is access like this {t1.Item1}");
        }
        
        
        public static (string address, bool valid) ValidateString(String address)
        {
            if (address.Equals("123 Seasamee st"))
            {
                return (address,true);
            }
            else
            {
                return (address,false);
            }
        }
    }
}


//