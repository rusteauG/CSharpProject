using System;

class ConsoleAppTest1
{
    static void Main(string[] args)
    {
        string userChoice; // More descriptive variable name

        do
        {
            Console.WriteLine("Enter a number: ");
            int num = int.Parse(Console.ReadLine());
            int start = 0;

            Console.WriteLine("Even numbers up to {0}:", num);
            while (start <= num)
            {
                Console.WriteLine(start);
                start += 2;
            }

            // Prompt user for continuation
            Console.Write("Do you want to continue (yes/no)? ");
            userChoice = Console.ReadLine().ToLower();

            // Validate user input
            if (userChoice != "yes" && userChoice != "no")
            {
                Console.WriteLine("Invalid input. Please enter 'yes' or 'no'.");
            }

        } while (userChoice == "yes"); // Exit loop when user enters "no"

        Console.WriteLine("Goodbye!");
    }
}