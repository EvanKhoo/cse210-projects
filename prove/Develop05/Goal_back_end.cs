public class Goal_back_end
{
    public int Score { get; private set; }
    public int GoalCount => _goals.Count;
    private List<Goal> _goals = new List<Goal>();

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ShowGoals()
    {
        Console.WriteLine("\nYour Goals:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].Name} — {_goals[i].Description}");
        }
    }

    public void RecordEvent(int index)
    {
        int pointsEarned = _goals[index].RecordEvent();
        Score += pointsEarned;
        Console.WriteLine($"You earned {pointsEarned} points! Total Score: {Score}");
    }

    public void Save(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            writer.WriteLine(Score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.SaveFormat());
            }
        }
    }

    public void Load(string filename)
    {
        _goals.Clear();

        string[] lines = File.ReadAllLines(filename);
        Score = int.Parse(lines[0]);

        for (int line = 1; line < lines.Length; line++)
        {
            string[] parts = lines[line].Split("|");
            string type = parts[0];

            if (type == "Simple")
            {
                var goal = new Simple(parts[1], parts[2], int.Parse(parts[3]));
                if (bool.Parse(parts[4])) goal.RecordEvent();
                _goals.Add(goal);
            }
            else if (type == "Eternal")
            {
                _goals.Add(new Eternal(parts[1], parts[2], int.Parse(parts[3])));
            }
            else if (type == "Checklist")
            {
                var goal = new Checklist(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])
                );

                int completed = int.Parse(parts[4]);
                for (int x = 0; x < completed; x++)
                    goal.RecordEvent();

                _goals.Add(goal);
            }
        }
    }
}
