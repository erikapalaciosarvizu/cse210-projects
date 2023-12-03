// The address contains a string for the street address, the city, state/province, and country.
// The address should have a method that can return whether it is in the USA or not.
// The address should have a method to return a string all of its fields together in one string (with newline characters where appropriate)

class Address
{
    private string _streetAddress;
    private string _city;
    private string _stateOrProvince;
    private string country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this._streetAddress = streetAddress;
        this._city = city;
        this._stateOrProvince = stateProvince;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.Equals("USA", StringComparison.OrdinalIgnoreCase);  // Check if the address is in the USA
    }

    public string GetAddressString()
    {
        // full address
        return $"{_streetAddress}\n{_city}, {_stateOrProvince}\n{country}";
    }
}
