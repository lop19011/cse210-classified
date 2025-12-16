using System;

namespace Foundation3
{
    public class OutdoorGathering : Event
    {
        private string _weatherForecast;

        //Constructor:

        public OutdoorGathering(string title, string description, string date, string time, Address address, string weatherForecast) : base(title, description, date, time, address)
        {
            _weatherForecast = weatherForecast;
        }

        //Polymorphism:

        public override string GetFullDetails()
        {
            string details = "FULL EVENT DETAILS\n";
            details += base.GetStandardDetails();
            details += $"Type: Outdoor Gathering\n";
            details += $"Weather Forecast: {_weatherForecast}\n";
            return details;

        }

        public override string GetShortDescription()
        {
            return $"Outdoor Gathering: {GetTitle()} on {GetDate()}";
        }

    }
}