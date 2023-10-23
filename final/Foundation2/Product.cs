public class Product
{
    private string _name;
    private string _productId;
    private int _quantity;
    private double _pricePer;

    public Product(string name, string ID, int quantity, double price)
    {
        _name = name;
        _productId = ID;
        _quantity = quantity;
        _pricePer = price;
    }
    public string GetName()
    {
        return _name;
    }
    public string GetProductId()
    {
        return _productId;
    }
    public int GetQuantity()
    {
        return _quantity;
    }
    public double GetPrice()
    {
        return _pricePer;
    }
    public double GetSubTotal()
    {
        double subtotal = GetQuantity() * GetPrice();
        return subtotal;
    }

}