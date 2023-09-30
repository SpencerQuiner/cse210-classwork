public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _words = new List<Word>();
        _reference = reference;
        //need to find a way to split the string of words into individual words and add them to the list, creating a new word object for each one.
        _words = SplitText(text);
    }

    public List<Word> SplitText(string text)
    {
        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            Word word1 = new Word();
            word1.SetText(word);
            word1.SetBool(false);
            _words.Add(word1);
        }
        return _words;
    }
    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText();
        foreach (Word word in _words)
        {
            scriptureText += ' ' + word.GetDisplayText();
        }

        return scriptureText;
    }
    public void HideRandomWords(int numberToHIde)
    {
        Random rand = new Random();
        for (int i = 0; i < numberToHIde; i++)
        {
            int wordIndex = rand.Next(0, _words.Count);
            _words[wordIndex].Hide();


        }
    }
    public bool IsCompletelyHidden()
    {
        bool totalHidden = false;
        foreach (Word word in _words)
        {
            if (word.IsHidden() == true)
            {
                totalHidden = true;
            }
            else
            {
                totalHidden = false;
            }
        }
        if (totalHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
