public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    private bool _isInUSA;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
        _isInUSA = IsInUSA();
    }

    public bool IsInUSA()
    {
        if (_country == "USA")
        {
            return true;
        }
        else return false;
    }

    public string GetAddressDetails()
    {
        return $"{_streetAddress}\n {_city} {_stateProvince}\n {_country}";
    }
}