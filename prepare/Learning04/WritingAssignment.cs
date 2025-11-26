using System;

namespace Homework
{
    public class WritingAssignment : Assignment
    {
        private string _title;





    // Constructor for WritingAssignment class
    public WritingAssignment(string studentName, string topic, string title) : base(studentName, topic)
        {
            _title = title;
        }

    public string GetWritingInformation()
        {
            string studentName = GetStudentName();
            return $"{_title} by {studentName}";
        }

    }
}