public class Order
{
    private Customer _customer;
    private List<Product> _products;
    public void TotalCost()
    {
        float cost = 0;
        foreach (Product prod in _products)
        {
            float prodPrice = prod.TotalPrice();
            cost += prodPrice;
        }
        if (_customer.IsAmerican())
        {
            cost += 5;
        }
        else
        {
            cost += 35;
        }
        Console.WriteLine(cost);
    }
    public void DisplayLabel()
    {
        Console.WriteLine(_customer.ShipLabel());
        // packing label c name id of product
        foreach (Product prod in _products)
        {
            Console.WriteLine(prod.PackLabel());
        }
        // shipping label c name address
        
    }
    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }
}