public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;
    public bool IsAmerican()
    {
        return _country == "USA";
    }
    public string GetAddress()
    {
        return _street + _city + _state + _country;
    }
}