Console.WriteLine("Enter a number:");
string? numberString = Console.ReadLine();
if (numberString == null)
{
    Console.WriteLine("Null");
}
else
{
    if (int.TryParse(numberString, out int num))
        Console.WriteLine(num);
    else { Console.WriteLine("Invalid Input"); }
}