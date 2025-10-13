using System;

class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new List<Student>();

        students.Add(new Student("Bob", "Jones", "122190232"));
        students[0].DisplayName();

        students.Add(new Student("Betty", "White", "123920332"));
        students[1];

        students[0].DisplayInfo();
        students[1].DisplayInfo();

        Course c1 = new Course("Programming with classes", students);
        c1.DisplayCourseInfo();
    }
}