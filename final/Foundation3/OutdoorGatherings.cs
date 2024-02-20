public class OutdoorGatherings : Event
{
    private string _forecast;

    public OutdoorGatherings(string title, string description, string date, string time, Address address, string forecast) : base(title, description, date, time, address)
    {
        _forecast = forecast;
    }

    public override string GetFullMessage()
    {
        return $"{GetStandardMessage()}\nWeather Forecast: {_forecast}";
    }
}