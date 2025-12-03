using System;

class Program
{
    static void Main(string[] args)
    {
        //input person or interface?
        Address address1 = new Address("250 avg st", "Khartoum", "Khartoum", "Sudan");
        Customer customer1 = new Customer("joe",address1);
        List<Product> products1 = new List<Product>();
        Product prod1 = new Product("Cu", 001, 2.40f, 8);
        Product prod2 = new Product("Au", 006, 4200, 1);
        Product prod3 = new Product("Firearm", 056, 350, 1);
        products1.Add(prod1);
        products1.Add(prod2);
        products1.Add(prod3);
        Order order1 = new Order(customer1, products1);

        Address address2 = new Address("150 E 300 N", "Rigby", "ID", "USA");
        Customer customer2 = new Customer("guy",address2);
        List<Product> products2 = new List<Product>();
        Product prod11 = new Product("apple", 002, 3.50f, 2);
        Product prod22 = new Product("poster", 008, 10.55f, 1);
        Product prod33 = new Product("pencil", 061, .80f, 4);
        products2.Add(prod11);
        products2.Add(prod22);
        products2.Add(prod33);
        Order order2 = new Order(customer2, products2);

        order1.DisplayLabel();
        order1.TotalCost();
        order2.DisplayLabel();
        order2.TotalCost();
    }
}