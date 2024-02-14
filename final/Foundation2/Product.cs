public class Product
{
    private string _name;
    private string _productID;
    private int _price;
    private int _quantity;
    private double _totalCost;

    public Product (string name, string productID, int price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    public int CalculateTotalPrice()
    {
        return 0;
    }
}