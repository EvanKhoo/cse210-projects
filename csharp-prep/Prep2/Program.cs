using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.WriteLine("Please enter your grade percentage: %");
        int userGrade = int.Parse(Console.ReadLine());
        char letter = 'G';
        char sign = ' ';

        //Grade determination logic
        if (userGrade >= 90 && userGrade <= 100)
        {
            letter = 'A';
        }
        else if (userGrade >= 80 && userGrade < 90)
        {
            letter = 'B';
        }
        else if (userGrade >= 70 && userGrade < 80)
        {
            letter = 'C';
        }
        else if (userGrade >= 60 && userGrade < 70)
        {
            letter = 'D';
        }
        else if (userGrade < 60)
        {
            letter = 'F';
        }
        else
        {
            Console.WriteLine("Sorry that is not an acceptable grade percentage.");
        }

        //Assigning signs to the user grade.
        if (userGrade % 10 >= 7 && userGrade >= 60 && userGrade <= 90)
        {
            sign = '+';
        }
        else if (userGrade % 10 <= 3 && userGrade >= 60)
        {
            sign = '-';
        }
        else
        {
            sign = ' ';
        }

        // Printing grades
        if (userGrade >= 70 && userGrade <= 100)
        {
            Console.WriteLine($"You got a {letter}{sign} grade.");
            Console.WriteLine("Good job you passed the class.");
        }
        else if (userGrade < 70 && userGrade >= 0)
        {
            Console.WriteLine($"You got a {letter}{sign} grade.");
            Console.WriteLine("Better try harder next time you failed!");
        }
        else
        {
            Console.WriteLine("You must be pretty special to get a grade like that.");
        }
    }
}