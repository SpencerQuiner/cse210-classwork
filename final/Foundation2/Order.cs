public class Order
{
    private List<Product> _products;
    private Customer _customer;
    private Address _address;
    public Order(Customer customer, Address address)
    {
        _products = new List<Product>();
        _customer = customer;
        _address = address;
    }
    public List<Product> GetProducts()
    {
        return _products;
    }
    public double CalculateTotal()
    {
        double _total = 0;
        double _shipping = 0.0;
        if (_address.USAddress())
        {
            _shipping = 5.0;
        }
        else
        {
            _shipping = 35.0;
        }
        foreach (Product item in _products)
        {
            _total = _total + item.GetSubTotal() + _shipping;
        }
        return _total;
    }
    public string CreatePackingLabel()
    {
        string PackingLabelString = " ";
        foreach (Product item in _products)
        {
            string productString = item.GetProductId() + " - " + item.GetName() + "  " + item.GetQuantity() + "   $" + item.GetSubTotal();
            PackingLabelString = PackingLabelString + productString + "\n";
        }

        PackingLabelString = PackingLabelString + "\n" + "Order Total: $" + CalculateTotal();
        return PackingLabelString;
    }
    public string CreateShippingLabel()
    {
        string ShippingLabelString = _customer.GetName() + "\n" + _address.GetAddressString();
        return ShippingLabelString;
    }
    public void AddProductToList(string name, string ID, int quantity, double price)
    {
        Product product = new Product(name, ID, quantity, price);
        _products.Add(product);
    }

}