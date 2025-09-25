/* 
Auth: Evan Khoo
Date: 09/24/25
IDE: Visual Studio Code
Desc: Take in a list of values from the user and practice manipulating and
      displaying the values.
*/

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        bool runningList = true;
        // Initialize list for holding user supplied values.
        List<double> numberList = new List<double>();

        do
        {
            // Prompt user for numbers to append to a list.
            Console.Write("Enter a list of numbers, type 0 when finished: ");
            bool validNumber = double.TryParse(Console.ReadLine(),
            out double userNumber);

            if (!validNumber)
            {
                Console.WriteLine("That is not a valid number: ");
                continue;
            }
            if (userNumber == 0)
            {
                if (numberList.Count == 0)
                {
                    Console.WriteLine($"Your list is empty.");
                    continue;
                }

                numberList.Sort();

                Console.WriteLine($"The sum is: {numberList.Sum()}");
                Console.WriteLine($"The avg is: {numberList.Average()}");
                Console.WriteLine("The largest number is: " +
                $"{numberList.Max()} ");

                double smallestPositiveNumber = double.MaxValue;

                foreach (double numbers in numberList)
                {
                    if (numbers > 0 && numbers < smallestPositiveNumber)
                    {
                        smallestPositiveNumber = numbers;
                    }
                }

                if (smallestPositiveNumber == double.MaxValue)
                {
                    Console.WriteLine("There are no positive numbers in " +
                        "your list.");
                }
                else
                {
                    Console.WriteLine("The smallest positive number is: " +
                        $"{smallestPositiveNumber}");
                }
                
                Console.WriteLine($"The sorted list is: ");

                foreach (double sortedNumList in numberList)
                {
                    Console.WriteLine($"{sortedNumList}");
                }
                runningList = false;
            }
            else
            {
                numberList.Add(userNumber);
            }
        } while (runningList);
    }
}