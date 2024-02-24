//Program.cs
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
            Console.Clear();
           

            string name = RequestData.GetAString("What is Your Name:");
            SayHi(name);

            UserMessages.ApplicationStartMessage(name);

           double x = RequestData.GetDouble("Enter a Value1: ");
           double y = RequestData.GetDouble("Enter a Value2: ");
            double z = CalculateData.Add(x, y);

            UserMessages.PrintResult($"{x} + {y} = {z}");

        }


        private static void SayHi(string s)
        {
            Console.WriteLine($"Hi {s}");
        }
    }
}


//CLASSES

//CalculateData.cs

namespace ConsoleUI
{
   static internal class CalculateData  //all members must be static

    {
        
        public static double Add(double x, double y)
        { return x + y; }
    
    }
}

//UserMessages.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class UserMessages
    {
        public static void ApplicationStartMessage(string firstName)
        {
            Console.WriteLine("Welcome to Static Demo App");
            int hour = DateTime.Now.Hour;
            if (hour < 12)
            { Console.WriteLine($"Good mroning"); }
            else if (hour < 19) { Console.WriteLine($"Good Afternoon {firstName}"); }
            else { Console.WriteLine("Godd Night"); }
       
        }

        public static void PrintResult(string messages)
        {
            Console.WriteLine(messages);
            Console.WriteLine();
            Console.WriteLine("Thank you for using .......");
        }

    }
}


// RequestData.cs

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class RequestData
    {
        public static string GetAString(string msg)
        {
            Console.Write(msg);
            string output = Console.ReadLine();

            return output;
        }

        public static double GetDouble(string message)
        {
            Console.Write(message);
            string numberText = Console.ReadLine();

            double output;
            bool isDouble = default;  // equivalent to: bool defaultBool = false;

            isDouble = double.TryParse(numberText, out output);

            while (isDouble == false)
            {
                Console.Write("This was not a Valid number ,Please Try Again\n> ");
                Console.Write(message);
                numberText = Console.ReadLine();
                isDouble = double.TryParse(numberText, out output);
            }
            return output;

        }
    }
}
