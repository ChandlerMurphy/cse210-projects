public class Order
{
    private List<Product> products = new List<Product>();
    private Customer _customer;
    private double _totalCost;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProductToOrder(Product product)
    {
        products.Add(product);
    }

    public void CalculateTotalOrderCost()
    {
        double totalCost = 0;
        foreach (Product product in products)
        {
            double price = product.CalculateTotalPrice();
            totalCost = totalCost + price;
        }
        double _shippingCost = DetermineShippingCost();
        _totalCost = totalCost + _shippingCost;

        Console.WriteLine("Order Total: ");
        Console.WriteLine($"Total Cost: ${_totalCost}\n");
    }

    public void CreatePackingLabel()
    {
        Console.WriteLine("Packing Label: ");
        foreach(Product product in products)
        {
            Console.WriteLine($"{product.GetName()} ~ {product.GetProductID()}");
        }
        Console.WriteLine("");
    }

    public void CreateShippingLabel()
    {
        Console.WriteLine("Shipping Label: ");
        Console.WriteLine($"{_customer.GetName()} ~ {_customer.GetAddress()}\n");
    }

    public int DetermineShippingCost()
    {
        bool USresidency = _customer.DetermineResidence();
        int _shippingCost = 0;
        if(USresidency)
        {
            _shippingCost = 5;
        } else 
        {
            _shippingCost = 35;
        }

        return _shippingCost;
    }

}
