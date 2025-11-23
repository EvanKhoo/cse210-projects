public class Checklist : Goal
{
    private int _timesCompleted;
    private int _target;
    private int _bonus;

    public Checklist(string name, string description, int points, int target, int bonus)
        : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _timesCompleted = 0;
    }

    public override int RecordEvent()
    {
        _timesCompleted++;

        if (_timesCompleted == _target)
            return Points + _bonus;

        return Points;
    }

    // Ensures completion after target number of attempts is reached.
    public override bool IsComplete() => _timesCompleted >= _target;

    public override string GetStatus()
    {
        string check = IsComplete() ? "[X]" : "[ ]";
        return $"{check} Completed {_timesCompleted}/{_target}";
    }

    public override string SaveFormat()
    {
        return $"Checklist|{Name}|{Description}|{Points}|{_timesCompleted}|{_target}|{_bonus}";
    }
}
