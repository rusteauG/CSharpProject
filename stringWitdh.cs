//ToString / String Interpolation, col width .padleft

            //implicit Conversion
            int a = 139 ;
            double b = a;
            Console.WriteLine(b.ToString(""));   // Explicit Way to conversion convert values to strings, 
            Console.WriteLine($"{(' ',6)}{b:F2}");
            Console.WriteLine($"{new string(' ', 6)}{"12.5"}");

            // Align with 6 spaces from the left using PadLeft
            Console.WriteLine($"{b:F2}".PadLeft(6 + $"{b:F2}".Length));
            
            
            // Format the string with two decimal places
            string formattedString = $"{b:F2}";

            // Align with 6 spaces from the left using PadLeft
            Console.WriteLine(formattedString.PadLeft(6 + formattedString.Length));


            Console.ReadLine();

            /*
             * 
          ToString() Method:

It's a method available on any object, and it's used to convert an object to its string representation.

It allows you to specify formatting options for certain types (e.g., numbers, dates) using overloads, like .ToString("F2") for two decimal places.

It's more explicit, and you have to explicitly call the method.
Example:


int number = 42;
string str = number.ToString(); // Explicit conversion
--------------------------------------------------------------------------
String Interpolation ($"{variable}"):

Introduced in C# 6.0, string interpolation provides a more concise and readable way to embed expressions inside string literals.

It automatically calls .ToString() on the interpolated expression.

It allows you to include expressions directly within the string, making the code cleaner and more readable.

Example:
int number = 42;
string str = $"{number}"; // Implicit conversion using string interpolation

In summary, both approaches can be used, but string interpolation is often preferred for its readability and conciseness, especially when you need to embed multiple expressions or format strings with dynamic content.   */