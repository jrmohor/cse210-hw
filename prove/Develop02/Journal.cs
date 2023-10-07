public class Journal 

{
    public List<JournalEntry> journalEntries = new List<JournalEntry>();

     public void WriteNewEntry()
    {
        Console.WriteLine("Select a prompt from the list:");
        List<string> prompts = new List<string>
        {
            "Did you remember to smile today?",
            "What was the best part of my day?",
            "What was the bad part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        for (int i = 0; i < prompts.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {prompts[i]}");
        }

        Console.Write("Enter the number of the prompt you choose: ");
        int promptIndex;
        if (int.TryParse(Console.ReadLine(), out promptIndex) && promptIndex >= 1 && promptIndex <= prompts.Count)
        {
            string selectedPrompt = prompts[promptIndex - 1];
            Console.Write($"Enter your response for '{selectedPrompt}': ");
            string response = Console.ReadLine();
            
            JournalEntry entry = new JournalEntry
            {
                Prompt = selectedPrompt,
                Response = response,
                Date = DateTime.Now
            };

            journalEntries.Add(entry);
            Console.WriteLine("Entry saved successfully.");
        }
        else
        {
            Console.WriteLine("Invalid prompt selection. Please try again.");
        }
    }

    public void DisplayJournal()
    {
        Console.WriteLine("Journal Entries:");
        foreach (var entry in journalEntries)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    public void SaveJournalToFile()
    {
        Console.Write("Enter the filename to save the journal: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in journalEntries)
                {
                    writer.WriteLine($"Date: {entry.Date}");
                    writer.WriteLine($"Prompt: {entry.Prompt}");
                    writer.WriteLine($"Response: {entry.Response}");
                    writer.WriteLine();
                }
            }

            Console.WriteLine("Journal saved to file successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }

    public void LoadJournalFromFile()
    {
        Console.Write("Enter the filename to load the journal: ");
        string fileName = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                journalEntries.Clear();
                while (!reader.EndOfStream)
                {
                    string dateLine = reader.ReadLine();
                    string promptLine = reader.ReadLine();
                    string responseLine = reader.ReadLine();
                    reader.ReadLine(); // Read an empty line

                    if (DateTime.TryParse(dateLine.Replace("Date: ", ""), out DateTime date))
                    {
                        JournalEntry entry = new JournalEntry
                        {
                            Date = date,
                            Prompt = promptLine.Replace("Prompt: ", ""),
                            Response = responseLine.Replace("Response: ", "")
                        };

                        journalEntries.Add(entry);
                    }
                }
            }

            Console.WriteLine("Journal loaded from file successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}



