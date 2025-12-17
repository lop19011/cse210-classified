using System;

namespace Foundation4
{
    public class Running : Activity
    {
        private double _distance;


        //Constructor
        public Running(string date, int minutes, double distance) : base(date, minutes)
        {
            _distance = distance;

        }
        public override double GetDistance()
        {
            return _distance;
        }

        public override string GetActivityType()
        {
            return "Running";
        }

    }
}