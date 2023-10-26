//Keeps track of the book, chapter, and verse information.

public class Reference
{
    public string Book { get; private set; } //THEY ARE READ ONLY, THAT'S WHY THEY ARE PRIVATE(?)
    public int Chapter { get; private set; }
    public int StartVerse { get; private set; }
    public int EndVerse { get; private set; } // THIS IS FOR CASES WITH RANGES OF VERSES, MORE OR LESS?

    // Constructor FOR *ONE* VERSE*.
    public Reference(string book, int chapter, int verse) //TAKES 3 PARAMETERS
    {
        Book = book;
        Chapter = chapter;
        StartVerse = verse;
        EndVerse = verse; // 
    }

    // CONSTRUCTOR *FOR MORE THAN ONE VERSE*
    public Reference(string book, int chapter, int startVerse, int endVerse) //Takes 4 parameters--CONSTRUCTOR OVERLOAD???
    {
        Book = book;
        Chapter = chapter;
        StartVerse = startVerse;
        EndVerse = endVerse;
    }
}
