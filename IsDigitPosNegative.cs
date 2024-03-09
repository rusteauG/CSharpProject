//Check if Digit,Decimal, positive,Negative,Zero Number
            Console.WriteLine("Enter a Number: ");
            string input = Console.ReadLine();

            bool isDouble = Double.TryParse(input, out double number);
            if (isDouble)
            {
                // Check if the parsed value is a whole number (integer)
                if (number % 1 == 0)// Check remainder after division by 1

                {
                    if (number > 0)
                    {
                        Console.WriteLine($"{number} is a positive digit");
                    }
                    else if (number < 0)
                    {
                        Console.WriteLine($"{number} is a negative digit");
                    }
                    else
                    {
                        Console.WriteLine($"{number} is zero");
                    }


                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine($"{input} is not a digit (contains decimals)");
                }




            }
            else
            {
                Console.WriteLine($"{input} is not a valid number");
            }

            
                Console.ReadLine();
            }