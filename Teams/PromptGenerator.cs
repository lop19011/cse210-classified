using System;
using System.Collections.Generic;

namespace Journal
{


    public class PromptGenerator
    {
        private List<string> _newPrompt = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What is one small thing I’m grateful for today?",
            "What made me smile today?"
        };

        public string RandomPrompt()
        {
            Random rnd = new Random();
            int indx = rnd.Next(_newPrompt.Count);
            return _newPrompt[indx];

        }
    }
}