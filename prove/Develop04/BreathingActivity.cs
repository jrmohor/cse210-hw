class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        Name = "Breathing Activity";
        Description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    public void Start()
    {
        base.Start();

        Console.WriteLine("Breathe in...");
        PerformBreathing();
        base.End();
    }

    public void PerformBreathing()
    {
        for (int i = 0; i < Duration; i++)
        {
            Console.WriteLine("Breathe out...");
            Thread.Sleep(1000);
            Console.WriteLine("Breathe in...");
            Thread.Sleep(1000);
        }
    }
}
