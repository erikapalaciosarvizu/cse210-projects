class Video
{
    // ATTRIBUTES.
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    private List<Comment> comments;

    // constructor.
    public Video(string title, string author, int length)
    {
        this._title = title;
        this._author = author;
        _lengthInSeconds = length;
        comments = new List<Comment>();
    }

    // METHOD TO ADD A COMMENT TO THE VIDEO.
    public void AddComment(string userName, string commentText)
    {
        Comment newComment = new Comment(userName, commentText);
        comments.Add(newComment);
    }

    // METHOD TO OBTAIN THE NUMBER OF COMMENTS
    public int GetNumberOfComments()
    {
        return comments.Count;
    }

    // to display video information and comments.
    public void ShowVideoInfo()
    {
        Console.WriteLine($"Title: {_title}.");
        Console.WriteLine($"Author: {_author}.");
        Console.WriteLine($"Length: {_lengthInSeconds} seconds.");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        // Show each video comment
        foreach (Comment comment in comments)
        {
            comment.DisplayComment();
        }

        Console.WriteLine(); // Salto de linea 
    }
}