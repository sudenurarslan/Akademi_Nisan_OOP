namespace PrivateLesson;

public class Student : User
{
    public Student(string name, string email) : base(name, email)
    {
    }

    public void RequestLesson(Teacher teacher, string subject)
    {
        Console.WriteLine($"{Name}, {teacher.Name} öğretmeninden {subject} dersi talep etti.");
    }
}