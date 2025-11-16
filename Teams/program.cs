using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml;
using Microsoft.VisualBasic;
using System.Runtime.CompilerServices;

namespace Journal
{
    class Program
    {
        static void Main(string[] args)
        {
            Journal NewJournal = new Journal();
            PromptGenerator newPrompt = new PromptGenerator();

            bool journalWorking = true;
            while (journalWorking)
            {
                Console.WriteLine("Journal Menu:");
                Console.WriteLine("1. Write in my journal");
                Console.WriteLine("2. See my journal");
                Console.WriteLine("3. Save my journal");
                Console.WriteLine("4. Load my journal");
                Console.WriteLine("5. Exit");
                Console.Write("Select an option 1-5: ");
                string selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        string selectionOne = newPrompt.RandomPrompt();
                        Console.WriteLine($"New entry: {selectionOne}");
                        Console.Write("My answer: ");
                        string inputOne = Console.ReadLine();
                        if (inputOne != null)
                        {
                            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                            Entry case1entry = new Entry(date, selectionOne, inputOne);
                            NewJournal.AddEntry(case1entry);
                            Console.WriteLine("input saved");

                        }
                        break;

                    case "2":
                        NewJournal.Display();
                        break;

                    case "3":
                        Console.WriteLine("Enter existing file to save: ");
                        string SaveFile = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(SaveFile))
                        {
                            string nameOfFile = SaveFile.EndsWith(".txt", StringComparison.OrdinalIgnoreCase)
                            ? SaveFile
                            : SaveFile + ".txt";

                            NewJournal.SaveFile(nameOfFile);

                        }

                        break;

                    case "4":
                        Console.WriteLine("\nJournals:");
                        string SavedJournals = Path.Combine("saved_journals");
                        if (!Directory.Exists(SavedJournals))
                        {
                            Directory.CreateDirectory(SavedJournals);
                        }

                        string[] textFiles = Directory.GetFiles(SavedJournals, "*.txt");

                        if (textFiles.Length == 0)
                        {
                            Console.WriteLine("No journals found.");
                            break;

                        }
                        for (int i = 0; i < textFiles.Length; i++)
                        {
                            Console.WriteLine($"{i + 1}. {Path.GetFileName(textFiles[i])}");

                        }

                        Console.Write("\nSelect a file: ");
                        string newSelection = Console.ReadLine();

                        if(int.TryParse(newSelection, out int fileNumber) && fileNumber > 0 && fileNumber <= textFiles.Length)
                        {
                            string selection = textFiles[fileNumber - 1];
                            NewJournal.LoadFile(selection);
                            NewJournal.Display();

                        }
                        break;

                    case "5":
                        journalWorking = false;
                        Console.WriteLine("Closing... bye!");
                        break;

                    default:
                        Console.WriteLine("Selection not valid");
                        break;


                }
                
            }
        }
    }
}