using System;

namespace Foundation4
{
    public class Swimming : Activity
    {
        private int _laps;

        //Constructor

        public Swimming(string date, int minutes, int laps) : base(date, minutes)
        {
            _laps = laps;
        }

        public override double GetDistance()
        {
            return _laps * 50.0 / 1000.0 * 0.62;
        }

        public override string GetActivityType()
        {
            return "Swimming";
        }
    }
}