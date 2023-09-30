public class Word
{
    private string _text;
    private bool _isHidden;
    //When the _ishHidden boolean is positive the word needs to be replaced with the equivilant number of _.
    public void SetText(string word)
    {
        _text = word;
    }
    public void SetBool(bool hidden)
    {
        _isHidden = hidden;
    }
    public string GetDisplayText()
    {
        string dispWord = _text;
        if (_isHidden == true)
        {
            for (int i = 0; i < dispWord.Length; i++)
            {
                dispWord = dispWord.Replace(dispWord[i], '_');
            }

        }
        else
        {

        }
        return dispWord;
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public void Show()
    {
        _isHidden = false;
    }
    public bool IsHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}