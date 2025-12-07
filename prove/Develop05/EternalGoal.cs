using System;

namespace EternalQuest
{
    public class EternalGoal : Goal
    {
        public EternalGoal(string shortName, string description, int points) : base(shortName, description, points)
        {
            
        }

        public override bool IsComplete()
        {
            return false;
        }

        public override void RecordEvent()
        {
            
        }

          public override int GetPointsEarned()
        {
            return GetPoints();
        }


        public override string GetDetailString()
        {
            return $"[ ] {GetName()} ({GetDescription()})";
        }

        public override string GetStringRepresentation()
        {
            return $"Eternal Goal: {GetName()}, {GetDescription()}, {GetPoints()}, {IsComplete()}";
        }

    }
}