using System;

class Program
{
    static void Main()
    {
        // Address for each event
        Address address1 = new Address("Rio Amazonas 181 st ", "Dolores Hidalgo", "Guanajuato", "37800");
        Address address2 = new Address("Miguel Hidalgo 15 st", "Benito Juarez", "Mexico City", "12956");
        Address address3 = new Address("Juarez 255 st", "Monterrey", "Nuevo Leon", "67890");

        // events of each type
        Lecture lectureEvent = new Lecture("World Mental Health Day Conference", "This intimate gathering features a distinguished speaker who will guide us through a journey of self-discovery, resilience, and empowerment.", DateTime.Now, TimeSpan.FromHours(4), address1, "Matt Weedon", 100);

        Reception receptionEvent = new Reception("Cultural Celebration", "This special event seeks to bring together individuals passionate about cultural exchange and diversity.", DateTime.Now, TimeSpan.FromHours(2), address2, "rsvp@gmail.com");

        Outdoor outdoorEvent = new Outdoor("NatureFest", "This outdoor event promises an exciting celebration of music and arts.", DateTime.Now, TimeSpan.FromHours(10), address3, "Sunny with a chance of clouds");


        Console.WriteLine("* Lecture Event - 'STANDARD DETAILS':\n" + lectureEvent.EventStandardDetails() + "\n");
        Console.WriteLine("* Lecture Event - 'FULL DETAILS':\n" + lectureEvent.EventFullDetails() + "\n");
        Console.WriteLine("* Lecture Event - 'SHORT DESCRIPTION':\n" + lectureEvent.EventShortDescription() + "\n");

        Console.WriteLine("* Reception Event - 'STANDARD DETAILS':\n" + receptionEvent.EventStandardDetails() + "\n");
        Console.WriteLine("* Reception Event - 'FULL DETAILS':\n" + receptionEvent.EventFullDetails() + "\n");
        Console.WriteLine("* Reception Event - 'SHORT DESCRIPTION'\n" + receptionEvent.EventShortDescription() + "\n");

        Console.WriteLine("* Outdoor Event - 'STANDARD DETAILS':\n" + outdoorEvent.EventStandardDetails() + "\n");
        Console.WriteLine("* Outdoor Event - 'FULL DETAILS':\n" + outdoorEvent.EventFullDetails() + "\n");
        Console.WriteLine("* Outdoor Event - 'SHORT DESCRIPTION':\n" + outdoorEvent.EventShortDescription() + "\n");
    }
}