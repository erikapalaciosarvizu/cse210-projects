//Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

public class Scripture
{
    public Reference Reference { get; private set; }
    //pass a List<Word> variable to the constructor. 
    public List<Word> Words { get; private set; }

    //CONSTRUCTOR
    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();

        //DIVIDE THE TEXT INTO WORDS AND CREATE WORD CLASS OBJECTS
        foreach (string wordText in text.Split(' '))
        {
            Words.Add(new Word(wordText));
        }
    }
    //CREATE HIDDEN WORDS METHOD:
    public void HideWords() //I HAD TO MODIFY THIS SO IT WOULD NOT STOCK IN THE MIDDLE OF THE PROGRAM****
    {
        Random rand = new Random();

        // FILTERS WORDS THAT ARE COMPLETELY HIDDEN.
        List<Word> wordsToHide = Words.Where(w => !w.IsHidden).ToList();

        // IF THERE ARE NO WORDS LEFT TO HIDE, COME BACK
        if (wordsToHide.Count == 0)
        {
            return;
        }

        // ** THIS PART CHOOSE A RANDOM WORD FROM THE WORDS THAT ARE NOT COMPLETELY HIDDEN.
        int indexToHide = rand.Next(wordsToHide.Count);
        wordsToHide[indexToHide].Hide();
    }

    //METHOD
    public string GetRenderedText() /// this thing is what makes it work and not delete everything added to the program class.
    {
        return $"{Reference.Book} {Reference.Chapter}:{Reference.StartVerse}-{Reference.EndVerse} " +
               string.Join(" ", Words.Select(w => w.GetRenderedText()));
    }

    //METHOD !!!
    public bool IsCompletelyHidden()
    {
        return Words.All(w => w.IsHidden);
    }

    //REFERENCEEEEE CLASS?
}
