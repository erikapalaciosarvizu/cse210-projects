//Keeps track of a single word and whether it is shown or hidden.

/* A class for a Word, which has the responsibility for storing the text of a word and whether it is hidden or not, might include some behaviors similar to these:

Hide
Show
Is Hidden
Get Rendered Text */

public class Word
{
    private string _textWord; //CONTAINS THE WORD
    private bool _isHidden; //BOOLEAN THAT INDICATES WHETHER THE WORD IS HIDDEN OR NOT.

    // Constructorrrrr
    public Word(string text)
    {
        _textWord = text;
        _isHidden = false;
    }


    public void Hide()
    {
        _isHidden = true;
    }
    //THIS IS ALREADY TRUE BECAUSE THE WORD IS ALREADY HIDDEN.
    public bool IsHidden
    {
        get { return _isHidden; }
    }

    public string GetRenderedText()//THIS METHOD RETURNS UNDERSCORES IF THE WORD IS HIDDEN.
    {
        return _isHidden ? new string('_', _textWord.Length) : _textWord;
    }
}
