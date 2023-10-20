using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public double _length;
    public List<Comment> _comments;
    public Video(string title, string author, double lenght)
    {
        _title = title;
        _author = author;
        _length = lenght;
        _comments = new List<Comment>();
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public double GetLength()
    {
        return _length;
    }
    public int CommentCount()
    {
        int count = _comments.Count();
        return count;
    }
}