public class Eternal : Goal
{
    public Eternal(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        return Points;
    }

    // This ensures the goal is never "completed"
    public override bool IsComplete() => false;

    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string SaveFormat()
    {
        return $"Eternal|{Name}|{Description}|{Points}";
    }
}
