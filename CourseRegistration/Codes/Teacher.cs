using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Codes
{
    internal class Teacher
    {
        public string Department { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int Age { get; set; }


        AgeCalculation ageCalculation = new();


        public Teacher(string _department, string _firstName, string _lastName, DateTime _dateOfBirth)
        {
            Department = _department;
            FirstName = _firstName;
            LastName = _lastName;
            DateOfBirth = _dateOfBirth;
            Age = ageCalculation.CalculateAge(_dateOfBirth);
        }
    }
}
