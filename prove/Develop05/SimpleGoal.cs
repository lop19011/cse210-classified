using System;

namespace EternalQuest
{
    
    public abstract class SimpleGoal : Goal
    {
        private bool _isComplete;


        public SimpleGoal(string shortName, string description, int points, bool isComplete) : base(shortName, description, points)
        {
            _isComplete = isComplete;
        }

        public override bool IsComplete()
        {
            return _isComplete;
        }

        public override void RecordEvent()
        {
            _isComplete = true;
        }

        public override string GetDetailString()
        {
            string status;

            if (_isComplete)
            {
                status = "[X]";
            }

            else
            {
                status = "[ ]";
            }

            return $"{status} {GetName()} ({GetDescription()})";
            
        }

        public override string GetStringRepresentation()
        {
            return $"Simple Goal: {GetName()}, {GetDescription()}, {GetPoints()}, {IsComplete()}";
        }


    }


}