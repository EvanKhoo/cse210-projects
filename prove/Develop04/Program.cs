using System;

class Program
{
    static void Main(string[] args)
    {
        new Program().Display();
    }

    public void Display()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== PICK AN ACTIVITY ====");
            Console.WriteLine("1: Breathing");
            Console.WriteLine("2: Reflection");
            Console.WriteLine("3: Listing");
            Console.WriteLine("4: Exit");
            Console.Write("Enter choice: ");
            string userChoice = Console.ReadLine();

            Action userAction = userChoice switch
        {
            "1" => () => new Breathing().DoBreathing(),
            "2" => () => new Reflection().DoActivity(),
            "3" => () => new ListingActivity().DoListing(),
            "4" => () => Environment.Exit(0),
            _ => () => Console.WriteLine("Invalid choice.")
        };

            Console.Clear();
            userAction.Invoke();

            Console.WriteLine("\nPress ENTER to return to menu...");
            Console.ReadLine();
            Console.Clear();
            Display();
        }
    }
}