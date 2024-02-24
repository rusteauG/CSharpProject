string input = Console.ReadLine();

if (String.IsNullOrEmpty(input))
{
    Console.WriteLine("The input string is empty or null.");
}
else
{
    Console.WriteLine("The input string is not empty or null.");
}

/*  To test for an empty or null string in C# using Console.ReadLine(), 
you can use the String.IsNullOrEmpty() method. This method returns true
 if the string is null or empty, and false otherwise. */