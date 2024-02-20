public class Lectures : Event
{
    private string _speaker;
    private int _capacity;

    public Lectures(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    public string GetLecturesDetails()
    {
        return $"The name of the speaker is: {_speaker}\n The site capacity is: {_capacity}";
    }

    public override string GetFullMessage()
    {
        return $"{GetStandardMessage()}\nSpeaker: {_speaker}\nCapacity: {_capacity}";
    }
}