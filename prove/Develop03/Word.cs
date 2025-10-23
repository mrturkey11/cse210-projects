public class Word
{
    string _word;
    string _hiddenvalue;
    bool _hidden;

    public Word(string word)
    {
        _word = word;
        foreach (char a in word)
            _hiddenvalue += "_";
    }

    public string ReturnWord()
    {
        return _hidden ? _hiddenvalue : _word;
    }

    public void UnHide()
    {
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }
}