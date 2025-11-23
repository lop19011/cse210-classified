using System;
using System.Collections.Concurrent;

namespace ScriptureMemorizer
{
    


    public class ScriptureReference
    {
        private string _book;
        private int _chapter;
        private int _verse;
        private int _secondVerse;
    

    public ScriptureReference(string book, int chapter, int verse, int secondVerse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _secondVerse = secondVerse;
        }

        public ScriptureReference(string book, int chapter, int verse)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _secondVerse = 0;
        }
        public string DisplayText()
        {
            if (_secondVerse == 0)
            {
                return $"{_book} {_chapter}:{_verse}";

            }
            else
            {
                return $"{_book} {_chapter}:{_verse}-{_secondVerse}";
            }

        }

    }

}
