//Guessing Game
using System;

namespace ConsoleUI
{
 public static class Program
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 300;
            int guess;
            int number;
            int guesses;

            while(playAgain )
            {
                guess = 0;
                guesses = 0;
                number = rnd.Next(min,max +1);
                //A Not Xor to check if 3 tries , too compicated for this , can use an if instead
                //while (!( (guess != number) ^ (guesses < 3) ) )
                while(guess != number)
                {
                    if (guesses < 3)
                    {
                        Console.WriteLine("Guess a number between " + min + " - " + max + ": ");
                        guess = Convert.ToInt32(Console.ReadLine());
                        if (guess > number)
                        { Console.Write("Guess is Too High"); }
                        else if (guess == number)
                        {
                            playAgain = false;
                            break;
                        }
                        else
                        {
                            Console.Write("Guess Too Low");
                        }
                      
                        guesses++;
                        Console.WriteLine();
                    }else
                    {
                        Console.Clear();
                        Console.WriteLine(" 3 Tries Over");
                        playAgain = false;
                        break;
                    }

                }

            }
        }
    }
}




//EG#2
using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;
            String response;

            while (playAgain)
            {
                guess = 0;
                guesses = 0;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low!");
                    }
                    guesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("YOU WIN!");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would you like to play again (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing! ... I guess");

            Console.ReadKey();
        }
    }
}



//eG#3
using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeMessage();

            while (PlayAgain())
            {
                StartNewGame();
            }

            ThanksMessage();
            Console.ReadKey();
        }

        private static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("Guess a number between 1 and 100.\n");
        }

        private static void StartNewGame()
        {
            Random random = new Random();
            int min = 1;
            int max = 100;

            int guess = 0;
            int number = random.Next(min, max + 1);
            int guesses = 0;

            while (guess != number)
            {
                guess = GetGuess(min, max);
                ProvideFeedback(guess, number);
                guesses++;
            }

            Console.WriteLine("Congratulations! You guessed the number in {0} tries.\n", guesses);
        }

        private static int GetGuess(int min, int max)
        {
            Console.WriteLine($"Guess a number between {min} and {max}: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        private static void ProvideFeedback(int guess, int number)
        {
            if (guess > number)
            {
                Console.WriteLine(guess + " is too high!\n");
            }
            else if (guess < number)
            {
                Console.WriteLine(guess + " is too low!\n");
            }
        }

        private static bool PlayAgain()
        {
            Console.WriteLine("Would you like to play again (Y/N): ");
            string response = Console.ReadLine().ToUpper();
            return response == "Y";
        }

        private static void ThanksMessage()
        {
            Console.WriteLine("Thanks for playing! ... I guess");
        }
    }
}
Use code