public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetCustomerName()
    {
        return $"Name: {_name}";
    }

    public string GetCustomerAddress()
    {
        return $"Address: {_address.GetAddressDetails()}";
    }

    public bool CustomerUSA()
    {
        return _address.IsInUSA();
    }

}