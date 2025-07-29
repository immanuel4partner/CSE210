public class Customer
{
    private string _name;
    private Address _address;

    // Constructor
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    // Method to get the customer's name
    public string GetName()
    {
        return _name;
    }

    // Method to check if the customer is in the USA
    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    // Method to get the customer's address as a formatted string
    public string GetAddressString()
    {
        return _address.GetFullAddress();
    }
}