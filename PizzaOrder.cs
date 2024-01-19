//Display Main menu
//Console.WriteLine("Welcome to Nevx Pizza");
//Console.WriteLine();
//Console.WriteLine(@"Please Select Your Pizza(\)");
//Console.WriteLine();
//Console.WriteLine("1. Napolitan Pizza   ($12.95)");
//Console.WriteLine("2. Sicilian Pizza    ($12.95)");
//Console.WriteLine("3. Californian Pizza ($12.95)");
//Console.WriteLine("4. Mexican Pizza     ($12.95)");
//Console.WriteLine("5. Exit ");
//Console.WriteLine();

//create the same menu using array
// Pizza menu items and prices
string[] pizzaOptions = { "Napolitan Pizza", "Sicilian Pizza", "Californian Pizza", "Mexican Pizza", "Exit" };
decimal[] pizzaPrices = { 12.95m, 13.95m, 15.95m, 12.95m,0 }; // Prices corresponding to each pizza option
bool exit = false;
do
{
    // Display Main menu
    Console.Clear();
    Console.WriteLine("Welcome to Nevx Pizza");
    Console.WriteLine();
    Console.WriteLine("Please Select Your Pizza:");
    Console.WriteLine();

    //Display Pizza Options
    for (int i = 0; i < pizzaOptions.Length; i++)
    {//(adjust the width of the format specifier - alignLeft + alignRight fro Prices )
        Console.WriteLine($"{i + 1}.{pizzaOptions[i],-20} ${pizzaPrices[i],6:F2} ");
    }

    // Read user input
    Console.Write("\nEnter your choice (1-5): ");
    int choice;
    // Validate user input
    while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
    {
        Console.WriteLine("Invalid input. Please enter a number between 1 and 5.");
        Console.Write("Enter your choice (1-5): ");
    }

    // Process user choice
    if (choice == 5)
    {
        Console.WriteLine("Thank you for choosing Nevx Pizza. Goodbye!");
        exit = true;
    }
    else
    {
        Console.WriteLine($"You selected: {pizzaOptions[choice - 1]} (${pizzaPrices[choice - 1]:F2})");
        // Add further processing based on the user's choice
        Console.WriteLine();
        Console.Write("Enter  Quantity: ");
        string? qtyPizza = Console.ReadLine();
        bool validQty = int.TryParse(qtyPizza, out int qty);
        while (!validQty || qty < 1)
        {
            Console.WriteLine("Invalid Quantity. Please enter a valid number.");
            Console.Write("Enter Quantity: ");
            qtyPizza = Console.ReadLine();
            validQty = int.TryParse(qtyPizza, out qty);
        }
        // Calculate pizza price * qty
        decimal totalOrderPrice = pizzaPrices[choice - 1] * qty;
        Console.Clear();
        Console.WriteLine($"Total Price For Order: {totalOrderPrice,6:F2}");

        // Ask the user to confirm and proceed with payment
        Console.Write("Ready to pay and confirm your order? (Y/N): ");
        char confirmKey = char.ToUpper(Console.ReadKey().KeyChar);

        if (confirmKey == 'Y')
        {
            // Order confirmation page
            Console.Clear();
            Console.WriteLine("Order Confirmation:");
            Console.WriteLine($"Pizza: {pizzaOptions[choice - 1]}");
            Console.WriteLine($"Quantity: {qty}");
            Console.WriteLine($"Total Price: ${totalOrderPrice,6:F2}");
            Console.WriteLine("\nThank you for your order!");

            // Allow the user to return to the main menu
            Console.WriteLine("\nPress any key to return to the main menu.");
            Console.ReadKey();
        }
        else
        {
            // If the user doesn't confirm, reset the loop to place a new order
            Console.Clear();
            Console.WriteLine("Order not confirmed. Placing a new order...");
        }
    }
    

}while(!exit);
