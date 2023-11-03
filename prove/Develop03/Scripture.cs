public class Scripture

{
    public Reference reference;
    //pass a List<Word> variable to the constructor. 
    public List<Word> words;

    //CONSTRUCTOR
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = new List<Word>();

        //DIVIDE THE TEXT INTO WORDS AND CREATE WORD CLASS OBJECTS
        foreach (string wordText in text.Split(' '))
        {
            words.Add(new Word(wordText));
        }
    }
    //CREATE HIDDEN WORDS METHOD:
    public void HideWords() //I HAD TO MODIFY THIS SO IT WOULD NOT STOCK IN THE MIDDLE OF THE PROGRAM****
    {
        Random rand = new Random();

        // FILTERS WORDS THAT ARE COMPLETELY HIDDEN.
        List<Word> wordsToHide = new List<Word>();

        foreach (Word word in words)
        {
            if (!word.isHidden)
            {
                wordsToHide.Add(word);
            }
        }

        if (wordsToHide.Count == 0)
        {
            return;
        }

        int indexToHide = rand.Next(wordsToHide.Count);
        wordsToHide[indexToHide].Hide();
    }

    public string GetRenderedText()
    {
        return $"{reference.book} {reference.chapter}:{reference.startVerse}-{reference.endVerse} " +
               string.Join(" ", words.Select(w => w.GetRenderedText()));
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in words)
        {
            if (!word.isHidden)
            {
                return false;
            }
        }
        return true;
    }
}


