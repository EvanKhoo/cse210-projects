public class Simple : Goal
{
    private bool _isComplete = false;

    public Simple(string name, string description, int points)
        : base(name, description, points) { }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override bool IsComplete() => _isComplete;

    public override string GetStatus()
    {
        return IsComplete() ? "[X]" : "[ ]";
    }

    public override string SaveFormat()
    {
        return $"Simple|{Name}|{Description}|{Points}|{_isComplete}";
    }
}
