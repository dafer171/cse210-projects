public class Receptions : Event
{
    private List<string> _emails;

    public Receptions(string title, string description, string date, string time, Address address, List<string> email) : base(title, description, date, time, address)
    {
        _emails = email;

    }

    public override string GetFullMessage()
    {
        string emails = string.Join("\n", _emails);
        return $"{GetStandardMessage()}\nRSVP Confirmed emails:\n{emails}";
    }
}