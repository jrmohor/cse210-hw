class FileManager
{
    public void SaveToFile(List<Product> products)
    {
        // Implement file-saving logic here
        Console.WriteLine("Data saved to file.");
    }

    public List<Product> LoadFromFile()
    {
        // Implement file-loading logic here
        Console.WriteLine("Data loaded from file.");
        return new List<Product>();
    }
}