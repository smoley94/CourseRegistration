using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Codes
{
    internal class Enrollment
    {
        public Student StudentInfo { get; set; }
        public Course CourseInfo { get; set; }

        public Enrollment(Student _studentInfo, Course _courseInfo)
        {
            StudentInfo = _studentInfo;
            CourseInfo = _courseInfo;
        }
    }
}
