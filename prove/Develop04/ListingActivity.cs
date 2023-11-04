class ListingActivity : Activity
{
    public ListingActivity()
    {
        Name = "Listing Activity";
        Description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }

    public void Start()
    {
        base.Start();

        // Random prompt
        string[] prompts = {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        string selectedPrompt = prompts[new Random().Next(prompts.Length)];
        Console.WriteLine($"Think about: {selectedPrompt}");
        Thread.Sleep(5000); // Pause for 5 seconds

        Console.WriteLine("Start listing items. Press Enter after each item.");
        int itemCount = 0;
        while (true)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(item))
                break;
            itemCount++;
        }

        Console.WriteLine($"You listed {itemCount} items.");
        base.End();
    }
}