namespace PrivateLesson;

class Program
{
    static void Main(string[] args)
    {
        Teacher teacher1 = new Teacher("Sudenur Arslan", "sudenurarslan13@gmail.com", "Matematik");
        Student student1 = new Student("Berra Arslan", "berrarslan@ex.com");

        teacher1.DisplayInfo();
        teacher1.TeachLesson();

        student1.DisplayInfo();
        student1.RequestLesson(teacher1, "Matematik");

        Console.ReadLine();
    }
}