class Logger // Logger class
{
    public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }

    public void LogError(string errorMessage)
    {
        Console.WriteLine($"Error: {errorMessage}");
    }
}