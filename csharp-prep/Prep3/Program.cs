/* 
Auth: Evan Khoo
Date: 09/24/25
IDE: Visual Studio Code
Desc: Creating a guess the number game to learn proper c# syntax
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        bool keepPlaying = true;

        do
        {
            Console.WriteLine("Hello Prep3 World!");

            // Intro.
            Console.WriteLine("This is the 'Guess a number' game.");
            Console.WriteLine("You try to guess a random number in the " +
            "fewest attempts.");

            // Generate a random number between 1 and the user's chosen value.
            Random rnd = new Random();
            int valueRandom = rnd.Next(1, 101);

            // Instruct the user to guess a higher or lower value.
            Console.WriteLine("Guess a number between 1 and 100.");

            // Initialize the list of guesses.
            List<string> alreadyGuessed = new List<string>();
            bool successfulGuess = false;

            // Starting the game.
            do
            {
                // Prompting the user for a guess.
                Console.Write("Pick a positive integer: ");
                bool validGuess = int.TryParse(Console.ReadLine(),
                out int currentGuess);

                if (!validGuess || currentGuess <= 0)
                {
                    Console.WriteLine("Please enter a positive number " +
                    "greater than 0.");
                    continue;
                }

                string currentGuessHigh = currentGuess + "↑";
                string currentGuessLow = currentGuess + "↓";

                if (currentGuess > valueRandom)
                {
                    // Stores user guess into the guess list.
                    alreadyGuessed.Add(currentGuessHigh);

                    // Displays the user's guess as too high.
                    Console.WriteLine("Too high!");

                    // Displays the guesses that user has already made.
                    Console.WriteLine($"The numbers you have guessed are: " +
                     $"{string.Join(", ", alreadyGuessed)}");
                }
                else if (currentGuess < valueRandom)
                {
                    alreadyGuessed.Add(currentGuessLow);
                    Console.WriteLine("Too low!");
                    Console.WriteLine($"The numbers you have guessed are: " +
                    $"{string.Join(", ", alreadyGuessed)}");
                }
                else
                {
                    alreadyGuessed.Add(currentGuess.ToString());
                    Console.WriteLine("Congratulations you guessed the " +
                    $"number in: {alreadyGuessed.Count} guess(es).");
                    successfulGuess = true;
                }

            } while (!successfulGuess);
            Console.Write("Would you like to keep playing? Y/N: ");
            string continuePlaying = Console.ReadLine().ToUpper();
            if (continuePlaying == "Y")
            {
                continue;
            }
            else
            {
                keepPlaying = false;
            }
        } while (keepPlaying);
    }
}