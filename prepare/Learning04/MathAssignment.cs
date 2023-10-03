public class MathAssignment : Assignment
{
    private string _textBookSection;
    private string _problems;
    public MathAssignment(string studentName, string topic, string textBook, string problems) : base(studentName, topic)
    {
        _textBookSection = textBook;
        _problems = problems;
    }
    public void SetTextBook(string textBook)
    {
        _textBookSection = textBook;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return "section" + _textBookSection + "-" + _problems;
    }
}