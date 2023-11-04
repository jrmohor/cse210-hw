public class ScriptureReference
{
    public string Text { get; private set; }

    public ScriptureReference(string referenceText)
    {
        Text = referenceText;
    }
    public override string ToString()
    
    {
        return Text;
    }
}