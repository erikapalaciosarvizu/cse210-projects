public class Assignment
{
    // Add the attributes as private member variables.
    private string _studentsName;
    private string _topic;

    // Create a constructor for this class that receives a student name and topic and sets the member variables.

    public Assignment(string receiveStudentsName, string receiveTopic)
    {
        _studentsName = receiveStudentsName;
        _topic = receiveTopic;
    }

    public string GetStudentName()
    {
        return _studentsName;
    }

    public string GetTopic()
    {
        return _topic;
    }


    // Add the method for GetSummary() to return the student's name and the topic.
    public string GetSummary()
    {
        return _studentsName + " - " + _topic;

    }
}
