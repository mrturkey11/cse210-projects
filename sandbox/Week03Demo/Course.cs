public class Course
{
    public string _courseName;
    List<Student> _students = new List<Student>();

    public Course(string courseName, List<Student> students)
    {
        _courseName = courseName;
        _students = students;
    }
    void DisplayCourseInfo()
    {
        Console.WriteLine(_courseName);
        foreach (Student student in _students)
        {
            Console.WriteLine($"{student._firstName} {student._lastName}");
        }
    }
}