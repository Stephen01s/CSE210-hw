public class Product
{
    private string _name;
    private int _id;
    private float _price;
    private int _quantity;
    public float TotalPrice()
    {
        return _price * _quantity;
    }

}