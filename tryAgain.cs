//hw
/* 
 * 1.Create an Array of 3 names
   2.Ask the user which num to select
 */
string[] firstNames = new string[3] { "neville ", "Tim", "Rusteau" };

do
{
    Console.Clear();
    Console.Write("Select a Num [ 1 - 3 ]");


    if (int.TryParse(Console.ReadLine(), out int selectedNum) && (selectedNum > 0 && selectedNum <= 3))
    {
        
        Console.WriteLine($"Name Selected: {firstNames[selectedNum - 1]}");
        break; // Added to exit the loop after a valid selection
    }
    else
    {
        Console.WriteLine("Invalid num. Please enter a number in the range 1 to 3 or press 0 to exit.");
        Console.Write("Do you want to try again? (y/n): ");
        char tryAgainResponse = Console.ReadKey().KeyChar;  
        if(tryAgainResponse.ToString().ToLower() !="y")
        {
            Console.WriteLine("\nExiting!");
            break;
        }
        Console.WriteLine();
    } 
} while (true);

////Declare Arrays
//string[] firstName = new string[2];
//firstName[0] = "tim";
//firstName[1] = "nev";

//string[] lastName = { "Tom", "Rusteau" };

//string[] fruits;
//fruits = new string[2];
//fruits[0] = "APPLE";
//fruits[1] = "Oranges";

//string[] names = new string[5] { " ", "", "", "", "" };

//Console.WriteLine($"{firstName[0]}{names[0]}{fruits[0]}");

//string data = "Tim,Sue,Nev,Rick,Morty";
//string[] fnames = data.Split(',');
//foreach (string name in fnames)
//{
//    Console.Write($"{name} ");
//}
//Console.WriteLine();
////2.Splitting by multiple delimiters:
//string address = "123 Main St, Seattle, WA 98109";
//string[] addrParts = address.Split(new char[] {',',' '},StringSplitOptions.RemoveEmptyEntries   );
//foreach (string addr in addrParts)
//{ Console.WriteLine(addr); }

//Console.WriteLine(addrParts.Length);