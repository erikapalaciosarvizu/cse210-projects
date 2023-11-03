//Keeps track of the book, chapter, and verse information.
public class Reference
{
    public string _book;
    public int _chapter;
    private int _startVerse;
    private int _endVerse;

    // Constructor FOR *ONE* VERSE*.
    public Reference(string book, int chapter, int verse) //TAKES 3 PARAMETERS
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse;
    }

    // CONSTRUCTOR *FOR MORE THAN ONE VERSE*
    public Reference(string book, int chapter, int startVerse, int endVerse) //Takes 4 parameters--CONSTRUCTOR OVERLOAD???
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }
}
