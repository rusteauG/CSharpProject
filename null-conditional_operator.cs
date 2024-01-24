using System;


class AccountTest
{
    static void Main()
    {
        Account account1 = new Account(" ");
        Account account2 = new Account(" ");

        // Define a default name
        string defaultName = "Guest";

        // Prompt for user input
        Console.Write("Enter your name (optional): ");
        string userName = Console.ReadLine();

        // Create a new object using user input or default name
        Account userAccount = new Account(userName ?? defaultName);

        // Display the assigned name
        if (userName == "")
        {
            Console.WriteLine($"Welcome, {defaultName}!");
        }
        else
        {
            Console.WriteLine($"Welcome, {userAccount.Name}!");
        }

        for (int i = 0; i < 2; i++)
        {
            Console.Write($"Account.Name{i+1}: ");
            string accountName = Console.ReadLine();
            if(i== 0)
            {
                account1.Name = accountName;
                Console.WriteLine($"{account1.Name}");
            }
            else
            {
                account2.Name = accountName;
                Console.WriteLine($"{account2.Name}");
            }
        }

        Console.ReadKey();
    }
}


-----------------------
using System;

 class Account
{
    //private string name; //instance var
    //public string Name {//property to get and set  the name instance var
    //    get { return name; }
    //    set { name = value; }
    //        }
    public string Name { get; set; }  // auto implement property
    public Account(string accountName)
    { Name = accountName; }


}

