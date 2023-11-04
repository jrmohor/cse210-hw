class Activity
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public int Duration { get; protected set; }

    public void Start()
    {
        Console.WriteLine($"Activity: {Name}");
        Console.WriteLine(Description);
        Duration = GetDuration();
        Console.WriteLine($"Duration: {Duration} seconds");
        Console.WriteLine("Prepare to begin...");
        Thread.Sleep(2000); // Pause for 2 seconds
    }

    public void End()
    {
        Console.WriteLine("Good job! You have completed the activity.");
        Console.WriteLine($"Duration: {Duration} seconds");
        Thread.Sleep(3000); // Pause for 3 seconds
    }

    protected int GetDuration()
    {
        int duration;
        do
        {
            Console.Write("Set the duration (in seconds): ");
        } while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0);
        return duration;
    }
}
