public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;
    //need to find a way for the program to parse the common reference format into these variables

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }
    public Reference(string book, int chapter, int start, int end)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }

    public void SetBook(string book)
    {
        _book = book;
    }
    public void SetChapter(int chapter)
    {
        _chapter = chapter;
    }
    public void SetStart(int start)
    {
        _startVerse = start;
    }
    public void SetEnd(int end)
    {
        _endVerse = end;
    }
    public string GetDisplayText()
    {
        string fullRef = _book + _chapter.ToString() + ":" + _startVerse.ToString() + "-" + _endVerse.ToString();
        return fullRef;
    }

}