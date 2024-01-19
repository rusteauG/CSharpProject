using System;
using System.Collections.Generic;

namespace GuestBookModular
{
    public static class GuestBookClass
    {
        private static Dictionary<string, int> guestDict = new Dictionary<string, int>();
        private static string[] guestNames;

        public static void Run()
        {
            Console.WriteLine("Guest Book");
            do
            {
                EnterFamilyDetails();
            } while (WantToTryAgain());

            DisplayGuestList();
            Console.WriteLine("Exiting Guest Book. Goodbye!");
        }

        private static void EnterFamilyDetails()
        {
            string familyName = GetValidFamilyName();

            if (familyName.ToLower() == "no")
            {
                return;
            }

            int guestNumber = GetValidGuestNumber();

            guestDict.Add(familyName, guestNumber);
            guestNames = GetGuestNames(guestNumber);
        }

        private static string GetValidFamilyName()
        {
            string familyName;
            do
            {
                Console.Write("Enter Family Name (or 'no' to quit): ");
                familyName = Console.ReadLine();

                if (familyName.ToLower() == "no")
                {
                    return familyName;
                }

                if (string.IsNullOrEmpty(familyName))
                {
                    Console.WriteLine("Empty Value For Name entered");
                }
                else
                {
                    return familyName; // Valid family name, exit the loop
                }
            } while (true);
        }

        private static int GetValidGuestNumber()
        {
            string GuestNumber;
            do
            {
                Console.Write("Enter Number Of Guests: ");
                GuestNumber = Console.ReadLine();

                if (int.TryParse(GuestNumber, out int guestNumber) && guestNumber > 0)
                {
                    return guestNumber; // Valid guest number, exit the loop
                }
                else
                {
                    Console.WriteLine("Invalid input for the number of guests. Please enter a valid number greater than 0.");
                }
            } while (true);
        }

        private static string[] GetGuestNames(int guestNumber)
        {
            string[] names = new string[guestNumber];

            for (int i = 0; i < guestNumber; i++)
            {
                names[i] = GetValidGuestName(i + 1);
            }

            return names;
        }

        private static string GetValidGuestName(int guestIndex)
        {
            string guestName;
            do
            {
                Console.Write($"Enter Guest List Name {guestIndex}: ");
                guestName = Console.ReadLine();

                if (!string.IsNullOrEmpty(guestName))
                {
                    return guestName; // Valid guest name, exit the loop
                }
                else
                {
                    Console.WriteLine("Empty Value For Guest Name entered");
                }
            } while (true);
        }

        private static void DisplayGuestList()
        {
            Console.WriteLine("\nGuest List:");

            foreach (var kvp in guestDict)
            {
                Console.WriteLine($"Family Name: {kvp.Key}, Number of Guests: {kvp.Value}");
                for (int i = 0; i < kvp.Value; i++)
                {
                    Console.WriteLine($"  Guest{i + 1}: {guestNames[i]}");
                }
            }
        }

        private static bool WantToTryAgain()
        {
            Console.Write("Do you want to try again? (Y/N): ");
            string response = Console.ReadLine().Trim().ToUpper();
            return response == "Y";
        }
    }
}
