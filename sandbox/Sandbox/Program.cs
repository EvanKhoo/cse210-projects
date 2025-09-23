using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        // Loops

        //foreach
        List<string> fruits = new List<string>() { "Apple", "Bannana", "Cherry" }; //list initialization

        foreach (string fruit in fruits) //foreach loop 
        {
            Console.WriteLine(fruit);
        }

        fruits.Add("Date");
        fruits.Add("Eggplant");
        fruits.Remove("Apple");
        //fruits.Clear(); //clears list
        fruits[0] = "Apricot";

        Console.WriteLine(fruits[0]);
        Console.WriteLine(fruits);

        // for
        // for i in range (0, 10)
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"i: {i}");
        }


        // while

        // Console.Write("Make a choice, (y or n): ");
        // string value = Console.ReadLine().ToUpper();
        // while (value != "Y" && value != "N")
        // {
        //     Console.Write("Choose y or n: ");
        //     value = Console.ReadLine().ToUpper();
        // }

        // do while - same result as above while loop
        
        string value;
        do
        {
            Console.Write("Enter y or n: ");
            value = Console.ReadLine().ToUpper();
        } while (value != "Y" && value != "N");
    }
}