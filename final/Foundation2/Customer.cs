using System;

namespace Foundation2
{
    public class Customer
    {
        private string _name;
        private Address _address;

        //Constructor
        public Customer(string name, Address address)
        {
            _name = name;
            _address = address;
        }

        //Encapsulation - Getters

        public string GetName()
        {
            return _name;
        }

        public Address GetAddress()
        {
            return _address;
        }

        //Abstraction
        public bool LivesInUSA()
        {
            return _address.IsInUSA();
        }

    }
}