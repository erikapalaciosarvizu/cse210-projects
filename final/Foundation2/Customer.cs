// The customer contains a name and an address.
// The name is a string, but the Address is a class.
// The customer should have a method that can return whether they live in the USA or not. (Hint this should call a method on the address to find this.)

class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();  // Check if the customer lives in the USA
    }

    public string GetName()
    {
        return _name;  // Get customer name
    }

    public Address GetAddress()
    {
        return _address;  // Get the customer's address
    }
}

