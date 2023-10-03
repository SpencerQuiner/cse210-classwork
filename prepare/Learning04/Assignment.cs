public class Assignment
{
    private string _studentName;
    private string _topic;

    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public void SetName(string name)
    {
        _studentName = name;
    }
    public void SetTopic(string topic)
    {
        _topic = topic;
    }
    public string GetSummary()
    {
        return _studentName + "-" + _topic;
    }
    public string GetStudentName()
    {
        return _studentName;
    }
}