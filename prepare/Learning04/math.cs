using System.Formats.Asn1;
using System.Security.AccessControl;

public class Math : Assignment
{
    private string _textBookSection;
    private string _problems;

    public Math(string textBook, string problem, string student, string topic) : base(student, topic)
    {
        _textBookSection = textBook;
        _problems = problem;
    }
    
    public string GetHomeWorkList()
    {
        return $"{_textBookSection} - {_problems}";
    }
}