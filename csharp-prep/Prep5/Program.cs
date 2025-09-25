/*
Auth: Evan Khoo
Date: 09/24/25
IDE: Visual Studio Code
Desc: Practice using functions in C#
 */
 
using System;

class Program
{
    // Displays the message, "Welcome to the Program!".
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    // Asks for and returns the user's name (as a string).
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string userName = Console.ReadLine();
        return userName;
    }

    // Asks for and returns the user's favorite number (as an integer).
    static int PromptUserNumber()
    {
        do
        {
            Console.Write("Please enter your favorite number: ");
            bool validNumber = int.TryParse(Console.ReadLine(),
            out int userNumber);

            if (validNumber)
            {
                return userNumber;
            }
            else
            {
                Console.WriteLine("Sorry that is not a valid number");
            }
        } while (true);
    }

    // Accepts out integer parameter and prompts the user for the year 
    // they were born. The out parameter is set to their birth year. 
    // This function does not return a value. 
    // The user's birth year is given back from the function 
    // via the out parameter.
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.WriteLine("Enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    // Accepts an integer as a parameter and 
    // returns that number squared (as an integer).
    static int SquareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }

    // Accepts the user's name, the squared number, 
    // and the user's birth year. Display the user's name 
    // and squared number. Calculate hold many years old they 
    // will turn this year and display that.
    static void DisplayResult(string userName, int squaredNumber, 
    int userBirthYear)
    {
        Console.WriteLine($"{userName}, the square of your " +
        $"number is {squaredNumber}");

        int currentAge = 2025 - userBirthYear;
        Console.WriteLine($"{userName}, you will turn {currentAge} " +
            "this year.");
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");

        int birthYear;

        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        PromptUserBirthYear(out birthYear);
        int numberSquared = SquareNumber(userNumber);
        DisplayResult(userName, numberSquared, birthYear);
    }
}