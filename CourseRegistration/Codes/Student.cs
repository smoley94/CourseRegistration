using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Codes
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }


        AgeCalculation ageCalculation = new();


        public Student (int _studentId, string _firstName, string _lastName, DateTime _dateOfBirth)
        {
            StudentId = _studentId;
            FirstName = _firstName;
            LastName = _lastName;
            DateOfBirth = _dateOfBirth;
            Age = ageCalculation.CalculateAge(_dateOfBirth);
        }
    }
}
