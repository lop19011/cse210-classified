using System;
using Foundation3;

class Program
{
    static void Main(string[] args)
    {
        // Event 1 (Lecture)

        Address address1 = new Address("516 Main St", "Springfield", "IL", "USA");
        Lecture lecture1 = new Lecture("Introduction to Computer Science", "Learn the basics of computer science.", "January 12, 2026", "2:00 PM", address1, "Dr. Jhonson", 100);


        // Event 2 (Reception)

        Address address2 = new Address("897 Elm St", "Metropolis", "NY", "USA");
        Reception reception1 = new Reception("Networking Event", "An opportunity to network with professionals.", "February 5, 2026", "6:00 PM", address2, "rsvp@events.com");


        // Event 3 (Outdoor Gathering)

        Address address3 = new Address("123 Park Ave", "Greenville", "CA", "USA");
        OutdoorGathering outdoor1 = new OutdoorGathering ("Music Festival", "Enjoy live music in the park.", "March 20, 2026", "5:00 PM", address3, "Sunny with a chance of clouds");

        // Messages:

        Console.WriteLine("--- Lecture Event ---\n");
        Console.WriteLine(lecture1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(lecture1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(lecture1.GetShortDescription());
        Console.WriteLine("\n---------------------\n");


        Console.WriteLine("--- Reception Event ---\n");
        Console.WriteLine(reception1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(reception1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(reception1.GetShortDescription());
        Console.WriteLine("\n---------------------\n");


        Console.WriteLine("--- Outdoor Gathering Event ---\n");
        Console.WriteLine(outdoor1.GetStandardDetails());
        Console.WriteLine();
        Console.WriteLine(outdoor1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(outdoor1.GetShortDescription());

    }
}