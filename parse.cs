using System;


class Welcome1
{
    static void Main()
    {
        while (true)
        {
            Console.Write("Enter Number1: ");
            string num1 = Console.ReadLine();
            Console.Write("Enter Number2: ");
            string num2 = Console.ReadLine();
            if (int.TryParse(num1, out int num3) && (int.TryParse(num2, out int num4)))
            {
                if (num3 > 0 && num4 > 0)
                {
                    Console.WriteLine($"Sum = {num3 + num4}");//Valid Int entered
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter a number greater than 0.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }
        }
        Console.ReadKey();
    }
}
