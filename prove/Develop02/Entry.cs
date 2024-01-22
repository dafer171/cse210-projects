public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;
    public string _feelings;

    public Entry()
    {

    }

    public void DisplayEntryDetails()
    {
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt Text: {_promptText}");
        Console.WriteLine($"Entry Text: {_entryText}");
        Console.WriteLine($"Entry Text: {_feelings}");

    }
}