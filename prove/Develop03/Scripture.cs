using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Scripture
    {
        //Took me a while to figure out that I needed to use ScriptureReference type here
        private ScriptureReference _reference;
        private List<Word> _words;

        public Scripture(ScriptureReference reference, string text)
        {
            _reference = reference;
            _words = new List<Word>();

            foreach (string word in text.Split(" "))
            {
                _words.Add(new Word(word));
            }
        }

        public void HideRandomWords(int count)
        {
            Random random = new Random();
            int hidden = 0;

            // program was crashing here because I was not checking if the word was already hidden, adding a variable to track hidden words.
            // This will check how many words are available to hide
            int availableWords = 0;
            foreach (Word word in _words)
            {
                if (!word.IsHidden)
                {
                    availableWords++;
                }
            }
            // Added to ensure we don't try to hide more words than are available!
            int wordsToHide = Math.Min(count, availableWords);

            // This checks if there are enough words to hide
            while (hidden < wordsToHide)
            {
                int index = random.Next(_words.Count);

                if (!_words[index].IsHidden)
                {
                    _words[index].IsHidden = true;
                    hidden++;
                }
            }
        }

        // This checks if all the words are hidden
        public bool IsCompleteHidden()
        {
            foreach (Word word in _words)
            {
                if (!word.IsHidden)
                {
                    return false;
                }
            }
            return true;
        }

        public void RenderDisplay()
        {
            Console.Write(_reference.DisplayText() + " ");

            foreach (Word word in _words)
            {
                word.Render();
                Console.Write(" ");
            }

            Console.WriteLine();
        }
    }
}