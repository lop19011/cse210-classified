using System;

namespace Foundation3
{
    public class Event
    {
        private string _title;
        private string _description;
        private string _date;
        private string _time;
        private Address _address;

        //Constructor:

        public Event(string title, string description, string date, string time, Address address)
        {
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
        }

        //Encapsulation:

        public string GetTitle()
        {
            return _title;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetDate()
        {
            return _date;
        }

        public string GetTime()
        {
            return _time;
        }

        public Address GetAddress()
        {
            return _address;
        }


        //Messages:

        public string GetStandardDetails()
       
        {
            string details = "STANDARD EVENT DETAILS\n";
            details += $"Title: {_title}\n";
            details += $"Description: {_description}\n";
            details += $"Date: {_date}\n";
            details += $"Time: {_time}\n";
            details += $"Address: {_address.GetFullAddress()}\n";
            return details;
        }

        public virtual string GetShortDescription()
        {
            return $"Event: {_title} on {_date}";
        }

        public virtual string GetFullDetails()
        {
            string details = "FULL EVENT DETAILS\n";
            details += GetStandardDetails();
            return details;
        }

    }
}