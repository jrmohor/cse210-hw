using System;

class Program
{
      
    static void Main()
    {
        bool exit = false;
        Journal note = new Journal();
        
        while (!exit)
        {
            Console.WriteLine("Journal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            int choice;
            if (int.TryParse(Console.ReadLine(), out choice))
            {
                switch (choice)
                {
                    case 1:
                        note.WriteNewEntry();
                        break;
                    case 2:
                        note.DisplayJournal();
                        break;
                    case 3:
                        note.SaveJournalToFile();
                        break;
                    case 4:
                        note.LoadJournalFromFile();
                        break;
                    case 5:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }
    }

}