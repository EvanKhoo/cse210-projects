using System.Formats.Asn1;

public class Writing : Assignment
{
    private string _title;

    public Writing(string student, string topic, string title) : base (student, topic)
    {
        _title = title;
        _studentName = student;
    }
    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}