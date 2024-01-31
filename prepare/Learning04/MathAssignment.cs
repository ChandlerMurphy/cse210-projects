public class MathAssignment : Assignment
{
    private string _textboodSection;
    private string _problems;

    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textboodSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textboodSection} Problems {_problems}";
    }
}