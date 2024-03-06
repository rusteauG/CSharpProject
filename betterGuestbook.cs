using System;
using System.Collections.Generic;
using System.Text;
using GuestBookLibrary.Model;
using System.Threading.Tasks;
using System.Data.SqlTypes;
//Capture Info about each guest
//Info to capture , FirstName,LastName,messages to host
//oonce done, loop through each guest and capture Info

namespace ConsoleUI
{
    public class Program
    {
        // Declare guests as static to share it across all instances of the Program class

        private static List<GuestModel> guests = new List<GuestModel>();
        static void Main(string[] args)
        {




            GetGuestInformation();
            PrintGuestInformation();
            Console.ReadLine();
        }




        private static void GetGuestInformation()
        {
            string moreGuessComing;
            do
            {
                GuestModel guest = new GuestModel();


                bool isValidInput = false;
                while (!isValidInput)
                {

                    guest.FirstName = GetInfoFromConsole("Enter Guest FirstName:");

                    //Need a way to grab the bool value when Set to check here!
                    isValidInput = !string.IsNullOrEmpty(guest.FirstName);

                    if (!isValidInput)
                    {
                        //Already Checked in  Set Property
                        //Console.WriteLine("Invalid first name. Please try again.");
                    }

                }
                Console.Write("Enter Guest LasttName:");
                guest.LastName = Console.ReadLine();

                Console.WriteLine("Enter Your Message :");
                guest.MessageToHost = Console.ReadLine();

                guests.Add(guest);

                Console.Clear();
                Console.WriteLine("Are more Guest Coming ? yes or no");
                moreGuessComing = Console.ReadLine();


            } while (moreGuessComing.ToLower() == "yes");
        }

        private static void PrintGuestInformation()
        {

            //display
            foreach (GuestModel g in guests)
            {
                Console.WriteLine($"{g.GuestInfo}");
            }

        }
        private static String GetInfoFromConsole(String message)
        {
            String output = "";
            Console.Write(message);
            output = Console.ReadLine();
            return output;
        }
    }
}



//Class Library

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestBookLibrary.Model
{
    public class GuestModel
    {
        private String _firstName;

        public String FirstName
        {

            get { return _firstName; }
            set
            {
                if (IsValidFirstName(value))
                {
                    _firstName = value;
                }
                else
                {
                    Console.WriteLine("Invalid first name. Please try again.");
                    // You can choose to throw an exception or handle it in another way.
                }
            }
        }


        public String LastName { get; set; }
        public String MessageToHost { get; set; }

        public string GuestInfo
        {
            get
            {
                return $"{FirstName}{LastName} Msg: {MessageToHost} ";
            }
        }

        private bool IsValidFirstName(string firstName)
        {
            // Add your validation logic here
            // For example, you might want to check if the name is not empty and contains only letters.
            return !string.IsNullOrEmpty(firstName) && firstName.All(char.IsLetter);
        }
    }
}
