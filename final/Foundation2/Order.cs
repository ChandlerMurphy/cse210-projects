public class Order
{
    private List<Product> products;
    private Customer _customer;
    private double _totalCost;
    private string _packingLabel;
    private string _shippingLabel;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProductToOrder(Product product)
    {

    }

    public string CalculateTotalOrderCost()
    {
        return "";
    }

    public void CreatePackingLabel()
    {

    }

    public string GetPackingLabel() 
    {
        return _packingLabel;
    }

    public void CreateShippingLabel()
    {

    }

    public string GetShippingLabel() 
    {
        return _shippingLabel;
    }

    public int DetermineShippingCost()
    {
        return 0;
    }

}
