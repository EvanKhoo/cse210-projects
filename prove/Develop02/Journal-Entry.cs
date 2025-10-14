using System;

public class JournalEntry
{
    
    public DateTime _currentDate = DateTime.Now;
    public string _fileName = "Journal.txt";
    public string _userWriting;
    public string _userEntry = "";
    public string _currentPrompt;

    public void Write(Menu Home, PromptGenerator Prompt)
    {
        _currentPrompt = Prompt.DisplayPrompt();
        Console.WriteLine($"{_currentDate}");
        Console.WriteLine("Press ENTER on a new line to return to menu.");
        Console.WriteLine(_currentPrompt);

        while (true)
        {
            _userWriting = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(_userWriting))
            {
                Home.Display(Prompt);
                return;
            }
            _userEntry += _userWriting + Environment.NewLine;
        }
    }

    public void Save(Menu Home, PromptGenerator Prompt)
    {

        if (string.IsNullOrWhiteSpace(_userEntry))
        {
            Console.WriteLine("No text to save!");
            return;
        }
        try
        {
            if (!File.Exists(_fileName))
                File.Create(_fileName).Close();

            using (StreamWriter saver = new StreamWriter(_fileName, append: true))
            {
                saver.WriteLine("----------------------------------------------");
                saver.WriteLine($"Date: {_currentDate}");
                saver.WriteLine(_currentPrompt);
                saver.WriteLine(_userEntry);
                saver.WriteLine();
            }

            Console.WriteLine($"Entry appended to {_fileName}.");
            _userEntry = "";
            _currentPrompt = "";
        }
        catch (Exception)
        {
            Console.WriteLine("Failed to save file...");
        }
        Home.Display(Prompt);
    }

    public void Read(Menu Home, PromptGenerator Prompt)
    {
        if (!File.Exists(_fileName))
        {
            Console.WriteLine("No journal exists.");
            return;
        }

        string printJournal = File.ReadAllText(_fileName);

        if (string.IsNullOrWhiteSpace(printJournal))
        {
            Console.WriteLine("Your journal is empty");
            return;
        }
        Console.WriteLine("==== YOUR JOURNAL ENTRIES ====\n");
        Console.WriteLine(printJournal);
        Console.WriteLine("================================\n");

        Home.Display(Prompt);
    }
}