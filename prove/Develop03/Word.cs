//Keeps track of a single word and whether it is shown or hidden.

/* A class for a Word, which has the responsibility for storing the text of a word and whether it is hidden or not, might include some behaviors similar to these:

Hide
Show
Is Hidden
Get Rendered Text */

public class Word
{
    public string TextWord { get; private set; } //CONTAINS THE WORD
    public bool IsHidden { get; private set; } //BOOLEAN THAT INDICATES WHETHER THE WORD IS HIDDEN OR NOT.

    // Constructorrrrr
    public Word(string text)
    {
        TextWord = text;
        IsHidden = false; //false because INITIALLY the word IS NOT HIDDEN.
    }

    public void Hide()
    {
        IsHidden = true; //THIS IS ALREADY TRUE BECAUSE THE WORD IS ALREADY HIDDEN.
    }

    public string GetRenderedText() //THIS METHOD RETURNS UNDERSCORES IF THE WORD IS HIDDEN.
    {
        return IsHidden ? new string('_', TextWord.Length) : TextWord;
    }
}


