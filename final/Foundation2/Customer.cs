public class Customer
{
    private string _name;
    private Address _address;
    public bool IsAmerican()
    {
        return _address.IsAmerican();
    }
    public string ShipLabel()
    {
        return _name + ":" + _address.GetAddress();
    }
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }
}