using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal static class ConsoleMessages
    {
        //Tuple
        public static (string,string) GetUsersName()
        {
            Console.WriteLine("What is your FirstName: ");
            string fname = Console.ReadLine();
            Console.WriteLine("What is your LastName: ");
            string lname = Console.ReadLine();

            return (fname,lname);
        }
    }
    
}


//In Main()

//(string fname, string lname) fullname = ConsoleMessages.GetUsersName();
//Console.WriteLine($"FirstName: {fullname.fname}");
//Console.WriteLine($"FirstName: {fullname.lname}");