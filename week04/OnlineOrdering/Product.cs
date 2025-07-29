public class Product
{
    private string _name;
    private string _productID;
    private double _price;
    private int _quantity;

    // Constructor
    public Product(string name, string productID, double price, int quantity)
    {
        _name = name;
        _productID = productID;
        _price = price;
        _quantity = quantity;
    }

    // Method to calculate total cost of this product
    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    // Method to get product name
    public string GetName()
    {
        return _name;
    }

    // Method to get product ID
    public string GetProductID()
    {
        return _productID;
    }

    // Method to get product price
    public double GetPrice()
    {
        return _price;
    }

    // Method to get product quantity
    public int GetQuantity()
    {
        return _quantity;
    }
}