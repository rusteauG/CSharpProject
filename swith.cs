Console.WriteLine("Enter a num");
string input = Console.ReadLine();

if (int.TryParse(input, out int? num))
{
    // Input successfully converted to int?
    switch (num)
    {
        case 0:
            Console.Clear();
            Console.WriteLine($"{num}");
            break;
        default:
            Console.WriteLine("Entered number is not 0.");
            break;
    }
}
else
{
    // Handling invalid input
    Console.WriteLine("Invalid input. Please enter a valid integer.");
}
