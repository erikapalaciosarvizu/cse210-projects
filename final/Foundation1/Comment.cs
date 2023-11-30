using System;
using System.Collections.Generic;

// almacenar información sobre los comentarios
class Comment
{
    // ATTRIBUTES
    private string commenterName;
    private string commentText;

    // CONSTRUCTOR
    public Comment(string name, string text)
    {
        commenterName = name;
        commentText = text;
    }

    // SHOW COMMENTS
    public void DisplayComment()
    {
        Console.WriteLine($"{commenterName}: {commentText}");
    }
}