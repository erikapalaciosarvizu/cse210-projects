
public class WritingAssignment : Assignment// set up the inheritance relationship.
{
    // Add the attributes as private member variables. 
    private string _titleOfTheTopic;

    // Create a constructor for this class that accepts three parameters,
    // have it call the base class constructor to set the base class attributes.
    public WritingAssignment(string receiveStudentsName, string receiveTopic, string receivetitleOfTheTopic) : base(receiveStudentsName, receiveTopic)
    {
        _titleOfTheTopic = receivetitleOfTheTopic;
    }

    public string GetWritingInformation()
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        string studentsName = GetStudentName();

        return $"{_titleOfTheTopic} by {studentsName}";
    }


}
