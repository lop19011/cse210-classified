using System;
using System.Collections.Generic;

namespace Journal
{
    public class Entry
    {
        // requested ChatGPT how to set up the string properties of Date, Prompt, and NewEntry and called them back recommended me to use {get; set;} to add protection and encapsulation.
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string NewEntry { get; set; }
        // corrected parameter names to match the property names
        public Entry(string date, string prompt, string newEntry)
        {
            Date = date;
            Prompt = prompt;
            NewEntry = newEntry;

        }

        // brother Matthew helped with this method, since I was struggling to figure out how to display the entry information.

        public void Display()
        {
            Console.WriteLine($"The date is: {Date}");
            Console.WriteLine("The prompt was:");
            Console.WriteLine($"{Prompt}");
            Console.WriteLine("The response was:");
            Console.WriteLine($"{NewEntry}");
            Console.WriteLine();


        }
    }
}