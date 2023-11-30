class Video
{
    // ATTRIBUTES.
    private string title;
    private string author;
    private string lengthInMinutes;
    private List<Comment> comments;

    // constructor.
    public Video(string title, string author, string length)
    {
        this.title = title;
        this.author = author;
        lengthInMinutes = length;
        comments = new List<Comment>();
    }

    // METHOD TO ADD A COMMENT TO THE VIDEO.
    public void AddComment(string commenterName, string commentText)
    {
        Comment newComment = new Comment(commenterName, commentText);
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
        Console.WriteLine($"Title: {title}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Length: {lengthInMinutes} minutes");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");

        // Show each video comment
        foreach (Comment comment in comments)
        {
            comment.DisplayComment();
        }

        Console.WriteLine(); // Salto de linea 
    }
}