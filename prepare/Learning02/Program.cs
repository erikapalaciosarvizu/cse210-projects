using System;

class Program
{
    static void Main()
    {
        // Esta es mi instancia
        Job job1 = new Job();

        // variables de mi clase
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // esto es para que imprima el nombre de la compa;ia

        // second job
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //job1.DisplayJob();
        //job2.DisplayJob();
        Resume myResume = new Resume();
        myResume._name = "Allison Rose";
        //punto = dame acceso a: (metodo/variable)
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.DisplayResume();
    }
}
