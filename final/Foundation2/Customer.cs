public class Customer
{
    private string _name;
    private Address _address;
    public bool IsAmerican()
    {
        return _address.IsAmerican();
    }
}