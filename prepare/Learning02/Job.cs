// Keeps track of the company, job title, start year, and end year.

/* Displays the job information in the format 
"Job Title (Company) 
StartYear-EndYear", 
for example: 
"Software Engineer (Microsoft) 2019-2022" */
public class Job //public quiere decir que se va a poder acceder a esto desde cualquier parte del codigo o proyecto
{
    public string _jobTitle;
    public string _company;
    public int _startYear;
    public int _endYear;

    public void DisplayJob()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}

