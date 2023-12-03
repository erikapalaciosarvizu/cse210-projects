using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // products
        Product product1 = new Product("Tell Me I'm Alive CD", "ATL9", 13.00, 2);
        Product product2 = new Product("EVERGREEN CD", "P03", 12.00, 6);

        // customer names and addresses
        Address address1 = new Address("#181 Rio Amazonas St", "Dolores Hidalgo", "GTO", "Mexico");
        Customer customer1 = new Customer("Erika Palacios", address1);

        Address address2 = new Address("4102 W Dorian St", "Boise", "ID", "USA");
        Customer customer2 = new Customer("Antonio Palacios", address2);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product1);

        // Show labels and costs
        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:\n" + order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine("\nOrder 2:");
        Console.WriteLine("Packing Label:\n" + order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:\n" + order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());
    }
}

