using System;

namespace Foundation3
{
    public class Lecture : Event
    {
        private string _speaker;
        private int _capacity;

        //Constructor:

        public Lecture(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
        {
            _speaker = speaker;
            _capacity = capacity;
        }

        //Polymorphism:

        public override string GetFullDetails()
        {
            string details = "FULL EVENT DETAILS\n";
            details += base.GetStandardDetails();
            details += $"Type: Lecture\n";
            details += $"Speaker: {_speaker}\n";
            details += $"Capacity: {_capacity}\n";
            return details;
        }

        public override string GetShortDescription()
        {
            return $"Lecture: {GetTitle()} on {GetDate()}";
        }


    }
}