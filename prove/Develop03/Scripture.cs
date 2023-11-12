//Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

public class Scripture

{
    private Reference _reference;
    //pass a List<Word> variable to the constructor. 
    private List<Word> _words;

    //CONSTRUCTOR
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        foreach (string wordText in text.Split(' '))
        {
            _words.Add(new Word(wordText));
        }
    }

    //CREATE HIDDEN WORDS METHOD:
    public void HideWords() //I HAD TO MODIFY THIS SO IT WOULD NOT STOCK IN THE MIDDLE OF THE PROGRAM****
    {
        Random rand = new Random();

        // FILTERS WORDS THAT ARE COMPLETELY HIDDEN.
        List<Word> wordsToHide = _words.Where(w => !w.IsHidden).ToList();


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
        return $"{_reference.GetBook()} {_reference.GetChapter()}:{_reference.GetStartVerse()}-{_reference.GetEndVerse()} " +
               string.Join(" ", _words.Select(w => w.GetRenderedText()));
    }

    //METHOD !!!
    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden);
    }
}
//REFERENCEEEEE CLASS?
