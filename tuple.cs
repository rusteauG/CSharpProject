//Tuple  -- Works in .net Core Only
 internal class ConsoleMessages
 {
     public static string GetUserName()
     {
         string? name = String.Empty;
         name = Console.ReadLine();
         if (String.IsNullOrEmpty(name))
         {
             do
             {
                 Console.Write("Value Wrong Enter Again: ");
                 name = Console.ReadLine();
             } while (String.IsNullOrEmpty(name));
         }
         return name;
     }

     public static string GetFullName()
     {
         Console.Write("Whats Your FirstName: ");
         string firstName = Console.ReadLine()!;
         Console.Write("Whats Your LasttName: ");
         string lastName = Console.ReadLine()!;

         return firstName + "," + lastName;
     }

     //Tuple
     public static (string firstName ,string LastName) GetFullNameT()
     {
         Console.Write("Whats Your FirstName: ");
         string firstName = Console.ReadLine()!;
         Console.Write("Whats Your LasttName: ");
         string lastName = Console.ReadLine()!;

         return (firstName,lastName);
     }

///main()

for (int i = 0; i < output.Length; i++)
{ Console.WriteLine(output[i]); }

//method#2 get multiples values using tuples
//(string, string) fullname =
//var fullname = ConsoleMessages.GetFullNameT();
//Console.WriteLine($"Fname: {fullname.Item1}");
//(string fName,string lName ) fullname =  ConsoleMessages.GetFullNameT();
//Console.WriteLine(fullname.lName);
//Console.WriteLine(fullname.fName);

//ShortCut
//(string firstName, string lastName) = ConsoleMessages.GetFullNameT();
//Console.WriteLine($"{firstName}");

//Discard Char - if we dont want to capture sec var use _
//We ignore one of the return type, not using it
(string firstName, _) = ConsoleMessages.GetFullNameT();
Console.WriteLine($"{firstName}");
