using System;

public class Menu
{
    public void Display()
    {
        Console.WriteLine("==== PICK A BOOK ====");
        Console.WriteLine("1: MORMON");
        Console.WriteLine("2: JACOB");
        Console.WriteLine("3: NEPHI");
        Console.WriteLine("4: EXIT");
        string _userChoice = Console.ReadLine();

        Action userAction = _userChoice switch
        {
            "1" => () => RunScripture(Reference.Mormon()),
            "2" => () => RunScripture(Reference.Jacob()),
            "3" => () => RunScripture(Reference.Nephi()),
            "4" => () => Environment.Exit(0),
            _ => () => Console.WriteLine("Invalid choice.")
        };

        Console.Clear();
        userAction.Invoke();
    }
      private void RunScripture(string text)
    {
        Word wordManager = new Word(text);

        while (!wordManager.AllHidden())
        {
            Console.Clear();
            Console.WriteLine(wordManager.GetText());
            Console.WriteLine("\nPress ENTER to hide another word or type 'quit' to return to menu:");
            
            string input = Console.ReadLine();
            if (input?.ToLower() == "quit") break;

            wordManager.HideRandomWord();
        }

        Console.Clear();
        Console.WriteLine("All words hidden!\n");
        Console.WriteLine(wordManager.GetText());
        Console.WriteLine("\nPress ENTER to return to menu...");
        Console.ReadLine();
        Console.Clear();
        Display();
    }
}