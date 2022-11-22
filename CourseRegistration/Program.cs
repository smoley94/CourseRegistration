using CourseRegistration.Codes;


Student Alexander = new Student(1, "Alexander", "K. H. Runge", new DateTime(1998, 11, 19));
Student Amanda = new Student(2, "Amanda", "V. Gudmand", new DateTime(2001, 10, 3));
Student Dennis = new Student(3, "Dennis", "D. B. Paaske", new DateTime(1981, 3, 22));
Student Ozan = new Student(4, "Ozan", "Korkmaz", new DateTime(1990, 5, 9));
Student Camilla = new Student(5, "Camilla", "Kløjgaard", new DateTime(1994, 12, 3));


Teacher Niels = new Teacher("Programmering","Niels", "Olesen", new DateTime(1971, 3, 3));


Course OOP = new Course("OOP", Niels);
Course Gp = new Course("Grundlæggende programmering", Niels);
Course St = new Course("Studieteknik", Niels);


List<Enrollment> enrollments = new List<Enrollment>()
{
    new Enrollment(Alexander, St),
    new Enrollment(Alexander, Gp),
    new Enrollment(Alexander, OOP),
    new Enrollment(Amanda, St),
    new Enrollment(Amanda, Gp),
    new Enrollment(Amanda, OOP),
    new Enrollment(Dennis, St),
    new Enrollment(Dennis, Gp),
    new Enrollment(Dennis, OOP),
    new Enrollment(Ozan, Gp),
    new Enrollment(Ozan, OOP),
    new Enrollment(Camilla, Gp),
    new Enrollment(Camilla, OOP)

};

foreach (var item in enrollments)
{
    Console.WriteLine(item.StudentInfo.FirstName + " " + item.StudentInfo.LastName + ", fag: " + item.CourseInfo.CourseName + ", lærer: " + item.CourseInfo.TeacherInfo.FirstName + " " + item.CourseInfo.TeacherInfo.LastName);
}

