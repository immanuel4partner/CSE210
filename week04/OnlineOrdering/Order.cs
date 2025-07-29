public class Order
{
    private List<Product> _products = new List<Product>(); // List of products in the order
    private Customer _customer; // Customer placing the order

    // Constructor
    public Order(Customer customer)
    {
        _customer = customer;
    }

    // Method to add a product to the order
    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    // Method to calculate total cost (including shipping)
    public double GetTotalCost()
    {
        double totalProductCost = 0;

        // Calculate sum of product costs
        foreach (Product product in _products)
        {
            totalProductCost += product.GetTotalCost();
        }

        // Determine shipping cost
        double shippingCost = _customer.IsInUSA() ? 5.00 : 35.00;

        return totalProductCost + shippingCost;
    }

    // Method to generate packing label
    public string GetPackingLabel()
    {
        string label = "Packing Label:\n";
        foreach (Product product in _products)
        {
            label += $"{product.GetName()} (ID: {product.GetProductID()})\n";
        }
        return label;
    }

    // Method to generate shipping label
    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddressString()}";
    }
}