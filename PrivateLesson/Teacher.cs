namespace PrivateLesson;

public class Teacher : User
{
    private string branch;

    public Teacher(string name, string email, string branch) : base(name, email)
    {
        this.branch = branch;
    }

    public string Branch
    {
        get { return branch; }
        set { branch = value; }
    }

    public void TeachLesson()
    {
        Console.WriteLine($"{Name}, {branch} dersi veriyor.");
    }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Ad: {Name}, Email: {Email}, Branş: {branch}");
    }
}