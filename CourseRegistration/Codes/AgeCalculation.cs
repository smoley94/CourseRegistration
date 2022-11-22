
namespace CourseRegistration.Codes
{
    internal struct AgeCalculation
    {
        public int CalculateAge(DateTime _dateOfBirth)
        {
            int age = (int)((DateTime.Now - _dateOfBirth).TotalDays / 365.242199);

            return age;
        }
    }
}
