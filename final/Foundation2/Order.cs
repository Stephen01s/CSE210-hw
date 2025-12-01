public class Order
{
    private Customer _customer;
    private List<Product> _product;
    public float TotalCost()
    {
        float cost = 0;
        foreach (Product prod in _product)
        {
            float prodPrice = prod.TotalPrice();
            cost += prodPrice;
        }
        return cost;
    }
    public string DisplayLabel()
    {
        
    }
}