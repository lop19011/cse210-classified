using System;

namespace Foundation2
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _stateProvince;
        private string _country;

        public Address(string streetAddress, string city, string stateProvince, string country)
        {
            _streetAddress = streetAddress;
            _city = city;
            _stateProvince = stateProvince;
            _country = country;

        }
        
        //Encapsulation - Getters
        public string GetStreetAddress()
        {
            return _streetAddress;

        }
       public string GetCity()
        {
            return _city;
        } 

        public string GetStateProvince()
        {
            return _stateProvince;
        }

        public string GetCountry()
        {
            return _country;
        }

        //Abstraction - check if address is in USA
        public bool IsInUSA()
        {
            return _country.ToUpper() == "USA" || _country.ToUpper() == "UNITED STATES";

        }
        //Abstraction
        public string GetFullAddress()
        {
            return $"{_streetAddress}\n{_city}, {_stateProvince}\n{_country}";
        }

    }
        
}