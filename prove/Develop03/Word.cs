using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        private bool _isHidden;
        
        // Added a public bool property to access the private variable _isHidden
        public bool IsHidden
        {
            get {return _isHidden;}
            set {_isHidden = value;}
        }

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
            

        }
        public void Render()
        {
            if (_isHidden)
            {
                Console.Write(new string('_', _text.Length));

            }
            else
            {
                Console.Write(_text);
            }
        }
    }

}