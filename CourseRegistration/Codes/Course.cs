using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseRegistration.Codes
{
    internal class Course
    {
        public string CourseName { get; set; }
        public Teacher TeacherInfo { get; set; }

        public Course(string _courseName, Teacher _teacherInfo)
        {
            CourseName = _courseName;
            TeacherInfo = _teacherInfo;
        }
    }
}
