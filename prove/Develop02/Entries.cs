using System;
using System.Collections.Generic;

namespace Journal
{
    public class Entry
    {
        public string Date { get; set; }
        public string Prompt { get; set; }
        public string NewEntry { get; set; }

        public Entry(string date, string prompt, string newEntry)
        {
            Date = date;
            Prompt = prompt;
            NewEntry = newEntry;

        }

        public void Display()
        {
            Console.WriteLine($"The date is: {Date}");
            Console.WriteLine("Think about the following:");
            Console.WriteLine($"{Prompt}");
            Console.WriteLine($"{NewEntry}");
            Console.WriteLine();


        }
    }
}