// Contains the name, product id, price, and quantity of each product.
// The price of this product is computed by multiplying the price and the quantity.

class Product
{
    private string _name;
    private string _productId;
    private double price;
    private int _quantity;

    public Product(string name, string productId, double price, int quantity)
    {
        this._name = name;
        this._productId = productId;
        this.price = price;
        this._quantity = quantity;
    }

    public double GetTotalPrice()
    {
        return price * _quantity;  // Calculate the total price
    }

    public string GetName()
    {
        return _name;  // Get product name
    }

    public string GetProductId()
    {
        return _productId;  // Get the product ID
    }
}

