using System;

class Program
{
    static void Main(string[] args)
    {
        // First order (USA)
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("Alice Smith", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "LP100", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "MS200", 25.50, 2));

        // Second order (International)
        Address address2 = new Address("456 Queen St", "Toronto", "ON", "Canada");
        Customer customer2 = new Customer("Bob Lee", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Tablet", "TB300", 350.00, 1));
        order2.AddProduct(new Product("Stylus Pen", "SP400", 29.99, 3));

        // Display orders
        DisplayOrder(order1);
        Console.WriteLine(new string('-', 40));
        DisplayOrder(order2);
    }

    static void DisplayOrder(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"Total Price: ${order.GetTotalCost():0.00}");
    }
}
// The classes Address, Customer, Order, and Product are  defined in their respective files as per the original code structure.