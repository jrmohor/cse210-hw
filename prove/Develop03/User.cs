public class User
{
    public string Name { get; private set; }
    public int Progress { get; private set; }

    public User(string name)
    {
        Name = name;
        Progress = 0;
    }

    public void MemorizeWord()
    {
        Progress++;
    }
}