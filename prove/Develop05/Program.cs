using System;

class Program
{
    static void Main()
    {
        Goal_back_end manager = new Goal_back_end();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("==== ETERNAL QUEST ====");
            Console.WriteLine("1: Create Goal");
            Console.WriteLine("2: List Goals");
            Console.WriteLine("3: Record Event");
            Console.WriteLine("4: Show Score");
            Console.WriteLine("5: Save");
            Console.WriteLine("6: Load");
            Console.WriteLine("7: Exit");
            Console.Write("Enter choice: ");

            string choice = Console.ReadLine();

            Action userAction = choice switch
            {
                "1" => () => CreateGoal(manager),
                "2" => () => manager.ShowGoals(),
                "3" => () => RecordEvent(manager),
                "4" => () => Console.WriteLine($"\nScore: {manager.Score}"),
                "5" => () => {
                    Console.Write("\nFilename to save: ");
                    manager.Save(Console.ReadLine());
                },
                "6" => () => {
                    Console.Write("\nFilename to load: ");
                    manager.Load(Console.ReadLine());
                },
                "7" => () => Environment.Exit(0),
                _ => () => Console.WriteLine("\nInvalid choice.")
            };

            Console.Clear();
            userAction();

            Console.WriteLine("\nPress ENTER to continue...");
            Console.ReadLine();
        }
    }

    static void RecordEvent(Goal_back_end manager)
    {
        manager.ShowGoals();
        Console.Write("\nWhich goal did you complete? ");
        int index = int.Parse(Console.ReadLine()) - 1;

        // This ensures that I don't index into goals that arent in there.

        if (index < 0 || index >= manager.GoalCount)
        {
            Console.WriteLine("\nInvalid goal number.");
            return;
        }
        manager.RecordEvent(index);
    }

    static void CreateGoal(Goal_back_end manager)
    {
        Console.Clear();
        Console.WriteLine("==== CREATE GOAL ====");
        Console.WriteLine("1: Simple Goal");
        Console.WriteLine("2: Eternal Goal");
        Console.WriteLine("3: Checklist Goal");
        Console.Write("Enter choice: ");

        string type = Console.ReadLine();

        Console.Write("\nName: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        Action createAction = type switch
        {
            "1" => () => manager.AddGoal(new Simple(name, description, points)),
            "2" => () => manager.AddGoal(new Eternal(name, description, points)),
            "3" => () =>
            {
                Console.Write("How many times needed? ");
                int target = int.Parse(Console.ReadLine());

                Console.Write("Bonus points: ");
                int bonus = int.Parse(Console.ReadLine());

                manager.AddGoal(new Checklist(name, description, points, target, bonus));
            },
            _ => () => Console.WriteLine("Invalid goal type.")
        };
        createAction();
        Console.WriteLine("\nGoal created!");
    }
}