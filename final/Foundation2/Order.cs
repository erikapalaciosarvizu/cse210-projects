// Contains a list of products and a customer. Can calculate the total cost of the order, and can return a string for the packing label, and can return a string for the shipping label.
// The total price is calculated as the sum of the prices of each product plus a one-time shipping cost.
// This company is based in the USA. If the customer lives in the USA, then the shipping cost is $5. If the customer does not live in the USA, then the shipping cost is $35.
// A packing label should list the name and product id of each product in the order.
// A shipping label should list the name and address of the customer

class Order
{
    private List<Product> productsAdded;
    private Customer _customerplacingtheorder;

    public Order(Customer _customerplacingtheorder)
    {
        this._customerplacingtheorder = _customerplacingtheorder;
        this.productsAdded = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        productsAdded.Add(product);
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in productsAdded)
        {
            totalPrice += product.GetTotalPrice();  // total
        }

        // shipping based on customer location
        if (_customerplacingtheorder.IsInUSA())
        {
            totalPrice += 5.0;
        }
        else
        {
            totalPrice += 35.0;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in productsAdded)
        {
            // add the product name and ID to the packaging label
            packingLabel += $"{product.GetName()} (ID: {product.GetProductId()})\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        // Return the shipping label with all the info needed
        return $"{_customerplacingtheorder.GetName()}\n{_customerplacingtheorder.GetAddress().GetAddressString()}";
    }
}
