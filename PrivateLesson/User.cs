namespace PrivateLesson;

public class User
{
    private string name;
    private string email;

    public User(string name, string email)
    {
        this.name = name;
        this.email = email;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"Ad: {name}, Email: {email}");
    }
}