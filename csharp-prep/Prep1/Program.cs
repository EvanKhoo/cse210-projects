using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep1 World!");

        string firstName = "Bob";
        Console.WriteLine("Hello " + firstName);
        Console.WriteLine($"Hello {firstName}");
        Console.Write($"Hello {firstName}");
        Console.Write("This is another line\n");

        Console.Write("What is your favorite color? ");
        string favoriteColor = Console.ReadLine();
        Console.WriteLine($"Your favorite color is {favoriteColor}");

        Console.Write("What is your age? ");
        int age = int.Parse(Console.ReadLine());
        Console.WriteLine($"Your age is {age}");

        int a = 13;
        int b = 7;
        int c = a + b;

        Console.WriteLine($"C is {c}");
        Console.WriteLine($"a/b is {a / b}");
        Console.WriteLine($"{(double)a / b}");
        Console.WriteLine($"{a % b}");

        double x = 1.5;
        float y = 3.5f;

        bool isDone = false;

        if (isDone)
        {
            Console.WriteLine("All done.");
        }
        else
        {
            Console.WriteLine("Not done yet.");

        }
        Console.WriteLine("What is your first name? ");
        string firstNameBond = Console.ReadLine();
        string firstNameCapitalized = char.ToUpper(firstNameBond[0]) + firstNameBond.Substring(1).ToLower();
        Console.WriteLine("What is your last name?");
        string lastNameBond = Console.ReadLine();
        string lastNameCapitalized = char.ToUpper(lastNameBond[0]) + lastNameBond.Substring(1).ToLower();
        Console.WriteLine($"Your name is {lastNameCapitalized}, {firstNameCapitalized} {lastNameCapitalized}.");
    }
}