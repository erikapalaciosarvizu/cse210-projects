//Keeps track of a single word and whether it is shown or hidden.

/* A class for a Word, which has the responsibility for storing the text of a word and whether it is hidden or not, might include some behaviors similar to these:

Hide
Show
Is Hidden
Get Rendered Text */

public class Word
{
    private string _textWord;
    public bool _isHidden;

    // Constructorrrrr
    public Word(string text)
    {
        _textWord = text;
        _isHidden = false; //false because INITIALLY the word IS NOT HIDDEN.
    }
    public string TextWord => _textWord;
    public bool IsHidden => _isHidden;

    public void Hide()
    {
        _isHidden = true; //THIS IS ALREADY TRUE BECAUSE THE WORD IS ALREADY HIDDEN.
    }

    public string GetRenderedText()
    {
        return IsHidden ? new string('_', TextWord.Length) : TextWord;
    }
}


