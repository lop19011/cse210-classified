using System;
using System.Collections.Generic;

namespace ScriptureMemorizer
{
    public class Word
    {
        private string _text;
        public bool isHidden;

        public Word(string text)
        {
            _text = text;
            isHidden = false;
            

        }
        public void Render()
        {
            if (isHidden)
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