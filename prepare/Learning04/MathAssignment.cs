public class MathAssignment : Assignment
{
    // Add the attributes as private member variables. 
    // Make sure that you do not create new member variables for the ones you inherited from the base class.
    private string _sectionOfTheBook;
    private string _problemsNumber;

    // Create a constructor for your class that accepts all four parameters, 
    //have it call the base class constructor to set the base class attributes that way.

    public MathAssignment(string receiveStudentsName, string receiveTopic, string receiveSectionNumber, string receiveProblemNumber) : base(receiveStudentsName, receiveTopic)
    {
        _sectionOfTheBook = receiveSectionNumber;
        _problemsNumber = receiveProblemNumber;
    }

    //Add the GetHomeworkList() method.
    public string GetHomeworkList()
    {
        return $"Section: {_sectionOfTheBook} Problems: {_problemsNumber}";
    }
}