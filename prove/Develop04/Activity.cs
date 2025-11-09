public class Activity
{

    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string desc, int duration)
    {
        _name = name;
        _description = desc;
        _duration = duration;
    }

    public void StartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"{_description}");

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.TryParse(Console.ReadLine(), out int result) ? result : 0;
        Console.WriteLine($"Starting {_name} for {_duration} seconds... ");

        Console.WriteLine("Get ready...");
        SpinnerAnimation(3);
    }

    public void EndingMessage()
    {
        Console.WriteLine($"\nGood job! You completed {_duration} seconds of {_name}.");
    }

    protected void SpinnerAnimation(int duration)
    {
         char[] spinner = { '|', '/', '-', '\\' };
        DateTime endTime = DateTime.Now.AddSeconds(duration);
        int counter = 0;

        while (DateTime.Now < endTime)
        {
            Console.Write($"\r{spinner[counter % spinner.Length]}");
            counter++;
            Thread.Sleep(100); 
        }

        Console.Write("\r ");
        Console.WriteLine();
    }
    
    protected void CountDown(string activityMessage, int countFrom)
    {
        for (int seconds = countFrom; seconds > 0; seconds--)
        {
            Console.Write($"\r{activityMessage}{seconds} ");
            Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}