using System;

namespace Homework
{
    public class Assignment
    {
        private string _studentName;
        private string _topic;

    //Constructor for Assignment class
    public Assignment(string studnetName, string topic)
        {
            _studentName = studnetName;
            _topic = topic;
        
        }

    public string GetStudentName()
        {
            return _studentName;
        }

    public string GetTopic()
        {
            return _topic;
        }

    public string GetSummary()
        {
            return $"{_studentName} - {_topic}";
        }


    }

}