public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;
    public Address(string street, string city, string state, string country)
    {
        _streetAddress = street;
        _city = city;
        _state = state;
        _country = country;
    }
    public string GetAddressString()
    {
        return _streetAddress + "\n" + _city + _state + "\n" + _country + "\n" + _country;
    }
    public string GetCountry()
    {
        return _country;
    }
    public bool USAddress()
    {
        if (_country == "US" || _country == "USA")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}