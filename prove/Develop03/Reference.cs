//Keeps track of the book, chapter, and verse information.

public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructor 1 VERSE
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    // Constructor +1 VERSE
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetStartVerse()
    {
        return _startVerse;
    }

    public int GetEndVerse()
    {
        return _endVerse;
    }
}
