using System;

class Program

{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();
        User user = new User(userName);

        string referenceText = "John 3:16";
        string scriptureText = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        Scripture scripture = new Scripture(referenceText, scriptureText);
        scripture.Display();

        while (!scripture.AllWordsHidden())
        {
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWord();
            user.MemorizeWord();
            Console.Clear();
            scripture.Display();
        }

        Console.WriteLine($"{user.Name}, you've memorized {user.Progress} words.");
        Console.WriteLine("All words in the scripture are hidden. Press Enter to exit.");
        Console.ReadLine();
    }
}