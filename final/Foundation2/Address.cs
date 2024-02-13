public class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateProvince;
    private string _country;
    private bool _USresidence;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
        if (country == "US")
        {
            _USresidence = true;
        }
        else 
        {
            _USresidence = false;
        }
    }

    public bool USresidence()
    {
        return _USresidence;
    }

    public string GetAddress()
    {
        return $"{_streetAddress} etc";
    }
}