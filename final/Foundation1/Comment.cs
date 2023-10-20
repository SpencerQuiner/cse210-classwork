public class Comment
{
    public string _commentor;
    public string _text;
    public Comment(string commentor, string text)
    {
        _commentor = commentor;
        _text = text;
    }
    public string GetCommentor()
    {
        return _commentor;
    }
    public string GetText()
    {
        return _text;
    }
}