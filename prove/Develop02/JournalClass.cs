using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using System.Xml;

namespace Journal
{
    public class Journal
    {

        public List<Entry> _lines = new List<Entry>();

        public void AddEntry(Entry entry)
        {
            _lines.Add(entry);
        }
        // made correction to the Display method, I was using a different method to display the journal entries.
        public void Display()
        {
            if (_lines.Count == 0)
            {
                Console.WriteLine("You have not added anything to your Journal yet.");

            }

            foreach (Entry item in _lines)
            {
                item.Display();
            }



        }

        // brother Matthew helped with this method, since I was struggling to figure out how to save the journal entries to a file.
        public void SaveFile(string file)
        {
            using (StreamWriter write = new StreamWriter(file))
            {
                foreach (Entry item in _lines)
                {
                    write.WriteLine($"{item.Date}|{item.Prompt}|{item.NewEntry}");

                }
            }
            Console.WriteLine("You saved your Journal!");

            
        }
        // brother Matthew helped with this method, I did not had the if statement with the File.Exists to check if the file existed before loading it.

        public void LoadFile(string file)
        {
            if (!File.Exists(file))
            {
                Console.WriteLine("Journal has not been created yet.");
                return;

            }

            _lines.Clear();
            string[] inputs = File.ReadAllLines(file);

            foreach (string input in inputs)
            {
                string[] blocks = input.Split('|');
                if (blocks.Length == 3)
                {
                    Entry entry = new Entry(blocks[0], blocks[1], blocks[2]);
                    _lines.Add(entry);

                    
                }
            }

            //moved the Console.WriteLine("Journal loaded"); outside of the foreach loop to avoid repeating the message multiple times.
            Console.WriteLine("Journal loaded");

        }


    }
    
    

            
        



}