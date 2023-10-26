public class Scripture
{
    public ScriptureReference Reference { get; private set; }
    public List<Word> Words { get; private set; }

    public Scripture(string referenceText, string text)
    {
        Reference = new ScriptureReference(referenceText);
        Words = text.Split(new[] { ' ', '\t', '\n', '\r', '.', ',', '!', '?', ':', ';', '-' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(word => new Word(word))
            .ToList();
    }

    public void Display()
    {
        Console.WriteLine($"{Reference}:");
        Console.WriteLine(string.Join(" ", Words));
    }

    public void HideRandomWord()
    {
        List<Word> unhiddenWords = Words.Where(word => !word.Hidden).ToList();
        if (unhiddenWords.Count == 0)
            return;

        Random random = new Random();
        int randomIndex = random.Next(unhiddenWords.Count);
        unhiddenWords[randomIndex].Hide();
    }

    public bool AllWordsHidden()
    {
        return Words.All(word => word.Hidden);
    }
}
