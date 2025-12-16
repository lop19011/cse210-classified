using System;

namespace Foundation3
{
    public class Reception : Event
    {
        private string _rsvpEmail;

        //Constructor:

        public Reception(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
        {
            _rsvpEmail = rsvpEmail;
        }

        //Polymorphism:

        public override string GetFullDetails()
        {
            string details = "FULL EVENT DETAILS\n";
            details += base.GetStandardDetails();
            details += $"Type: Reception\n";
            details += $"RSVP Email: {_rsvpEmail}\n";
            return details;
        }

        public override string GetShortDescription()
        {
            return $"Reception: {GetTitle()} on {GetDate()}";
        }

    }
}