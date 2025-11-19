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
    // Brother Matthew helped me a lot in the program, since I was struggling pulling and setting everything together.
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
                    // Changed all the case numbers, since it was not working with the "." after the number.
                    // Brother Matthew share with me several system functions to help me with the file handling and directory checking, like: Directory.Exists, Directory.CreateDirectory, Path.Combine, Path.GetFileName, and Directory.GetFiles.
                    case "1":
                        string selectionOne = newPrompt.RandomPrompt();
                        Console.WriteLine($"New entry: {selectionOne}");
                        Console.Write("My answer: ");
                        string inputOne = Console.ReadLine();
                        if (inputOne != null)
                        {
                            // Asked ChatGPT how to get the current date and time and format, it recommended me to use DateTime.Now.ToString("yyyy-MM-dd HH:mm")
                            string date = DateTime.Now.ToString("yyyy-MM-dd HH:mm");
                            Entry case1entry = new Entry(date, selectionOne, inputOne);
                            NewJournal.AddEntry(case1entry);
                            Console.WriteLine("input saved");

                        }
                        break;
                    // Was not pulling the Display method from the JournalClass, so I corrected it from NewJournal.DisplayAll(); to NewJournal.Display();
                    case "2":
                        NewJournal.Display();
                        break;

                    case "3":
                        Console.WriteLine("Enter existing file to save: ");
                        string SaveFile = Console.ReadLine();
                        if (!string.IsNullOrWhiteSpace(SaveFile))
                        {
                            // Added check to ensure the file name ends with .txt , since I was having issues loading the files later.Brother Matthew helped me with this.
                            string nameOfFile = SaveFile.EndsWith(".txt", StringComparison.OrdinalIgnoreCase)
                            ? SaveFile
                            : SaveFile + ".txt";

                            NewJournal.SaveFile(nameOfFile);

                        }

                        break;
                    // this is not functioning correctly, filw is not being loaded. Brother Matthew helped me with several parts of this case. but is still not working properly.
                    case "4":
                        Console.WriteLine("\nJournals:");
                        string SavedJournals = Path.Combine("Develop02");
                        if (!Directory.Exists(SavedJournals))

                        // I have to revise this line, since I dont think is creating the directory properly.
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

                        // Brother Matthew shared the TryParse method to help me with the file selection and avoid errors, it also helped add the && conditions to check if the number was in range.

                        if(int.TryParse(newSelection, out int fileNumber) && fileNumber > 0 && fileNumber <= textFiles.Length)
                        {
                            string filepath = textFiles[fileNumber - 1];
                            NewJournal.LoadFile(filepath);
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