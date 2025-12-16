using System;

namespace Foundation3
{
    public class Address
    {
        private string _street;
        private string _city;
        private string _state;
        private string _country;



        //Constructor:
        public Address(string street, string city, string state, string country)
        {
            _street = street;
            _city = city;
            _state = state;
            _country = country;
        }

        //Abstraction:
        public string GetFullAddress()
        {
            return $"{_street}, {_city}, {_state}, {_country}";
        }

        
    }

}