using System;
using System.Collections.Generic;

// store information about comments
class Comment
{
    // ATTRIBUTES
    private string _userName;
    private string commentText;

    // CONSTRUCTOR
    public Comment(string name, string text)
    {
        _userName = name;
        commentText = text;
    }

    // SHOW COMMENTS
    public void DisplayComment()
    {
        Console.WriteLine($"{_userName}: {commentText}");
    }
}