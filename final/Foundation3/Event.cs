public class Event
{
    private string _eventTitle;
    private string _eventDescription;
    private string _eventDate;
    private string _eventTime;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _eventTitle = title;
        _eventDescription = description;
        _eventDate = date;
        _eventTime = time;
        _address = address;
    }

    public string GetStandardMessage()
    {
        string eventAddress = _address.GetAddressDetails();
        return $"\nTitle: {_eventTitle}\nDescription: {_eventDescription}\nDate: {_eventDate}\nTime: {_eventTime}\nAddress: {eventAddress}";
    }

    public virtual string GetFullMessage()
    {
        return GetStandardMessage();
    }

    public string GetShortMessage()
    {
        return $"\nType: {GetType().Name} Title: {_eventTitle} Date: {_eventDate}";
    }

}