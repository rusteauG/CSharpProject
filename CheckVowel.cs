
internal class Program
{
    private static void Main(string[] args)
    {
        ManipulatingString();
        string input = "Hello, World!";
        CheckVowels(input);
        Console.WriteLine(RemoveVowels(input));
        Console.WriteLine(RemoveVowels1(input));
    }
    public static void ManipulatingString()
    {
        String firstName = "Neville";
        String lastName = " Rusteau";
        String middleName = "Shaq";
        String fullName = String.Concat(lastName, firstName);
        // Using string.Concat with multiple arguments
        fullName = string.Concat(lastName, " ", firstName, " ", middleName).ToLower();
        Console.WriteLine(fullName);
        Console.WriteLine(fullName.Length);

        if (fullName.Contains("Rusteau") || fullName.Contains("Neville"))
        {
            Console.WriteLine("Found");
        }
        else { Console.WriteLine("NotFound!"); }


        //case-insensitive search, you can use the StringComparison enumeration and specify StringComparison.OrdinalIgnoreCase:
        fullName = "rusteau Neville John";

        bool containsRusteau = fullName.Contains("Rusteau", StringComparison.OrdinalIgnoreCase);

        Console.WriteLine(containsRusteau);

        String substring = fullName.Substring(0, 1); //r
        Console.WriteLine(substring);

    }
    static void CheckVowels(string input)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
        for (int i = 0; i < input.Length; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                if (input[i] == vowels[j]) { Console.Write($"Vowel Found At {i} {vowels[j]}"); break; }
                
            }
            Console.WriteLine();

        }



    }


    static string RemoveVowels(string input)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        // Initialize an empty string to build the result
        string result = "";

        // Loop through each character in the input
        foreach (char c in input)
        {
            // Check if the character is not a vowel and append it to the result
            if (Array.IndexOf(vowels, c) == -1)
            {
                result += c;
            }
        }

     
        return result;
    }


    static string RemoveVowels1(string input)
    {
        char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };

        // Convert the input string to a char array for easier manipulation
        char[] characters = input.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            if (Array.IndexOf(vowels, characters[i]) != -1)
            {
                // If the current character is a vowel, remove it by replacing with an empty char
                characters[i] = '\0'; // You can replace it with any character or an empty char
            }
        }

        // Convert the modified char array back to a string
        string result = new string(characters);

        return result;
    }

}