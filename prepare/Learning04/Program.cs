using System;


/* Create a simple assignment, call the method to get the summary, and then display it to the screen. */


class Program
{
    static void Main(string[] args)
    {
        Assignment class1 = new Assignment("Erika Palacios", "Multiplication");
        Console.WriteLine(class1.GetSummary());

        //and creating a new MathAssignment object and set its values. 
        // Make sure to test both the GetSummary() and the GetHomeworkList() methods.
        MathAssignment class2 = new MathAssignment("Leonela Lujan", "Fractions", "5.6", "5-17");
        Console.WriteLine(class2.GetSummary());
        Console.WriteLine(class2.GetHomeworkList());

        WritingAssignment class3 = new WritingAssignment("Jose Carita", "European History", "The Causes of World War II");
        Console.WriteLine(class3.GetSummary());
        Console.WriteLine(class3.GetWritingInformation());
    }
}