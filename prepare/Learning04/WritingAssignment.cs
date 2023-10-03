public class WritingAssignment : Assignment
{
    private string _title;
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
    {
        _title = title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetWrittingInformation()
    {
        return _title + " by " + GetStudentName();
    }
}