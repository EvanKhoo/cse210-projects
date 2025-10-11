using System;

public class Menu
{
    JournalEntry Journal = new JournalEntry();
    public void Display(PromptGenerator Prompt)
    {
        Console.WriteLine("==== JOURNAL MENU ====");
        Console.WriteLine("1: Write");
        Console.WriteLine("2: Read");
        Console.WriteLine("3: Save");
        Console.WriteLine("4: Exit");
        string _userChoice = Console.ReadLine();

        // I had ChatGPT teach me how to write switch statements, but I
        // Wrote this one on my own.
        Action userAction = _userChoice switch
            {
                "1" => () => Journal.Write(this, Prompt),
                "2" => () => Journal.Read(this, Prompt),
                "3" => () => Journal.Save(this, Prompt),
                "4" => () => Environment.Exit(0),
                _   => () => Console.WriteLine("Invalid choice.")
            };
            
        Console.Clear();
        userAction.Invoke();
    }
}
