using System;

namespace Foundation2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Order 1 (USA)

            Address address1 = new Address("648 Main St", "Bartow", "Florida", "USA");
            Customer customer1 = new Customer("Ryan Gosling", address1);

            Order order1 = new Order(customer1);
            order1.AddProduct(new Product("Desktop Computer", "TECH-001", 1700.00, 1));
            order1.AddProduct(new Product("Keyboard", "TECH-014", 149.75, 1));
            order1.AddProduct(new Product("Hard Drive 512 GB", "TECH-034", 75.85, 2));


            // Order 2 (Canada)

            Address address2 = new Address("785 King St", "Toronto", "Ontario", "Canada");
            Customer customer2 = new Customer("Emma Stone", address2);

            Order order2 = new Order(customer2);
            order1.AddProduct(new Product("Mouse", "TECH-015", 39.99, 1));
            order1.AddProduct(new Product("Gaming Headset", "TECH-025", 99.90, 1));
            order1.AddProduct(new Product("HDMI Cable", "TECH-088", 12.99, 5));


            // Order 1 Summary Display:

            Console.WriteLine("Order 1: ");
            Console.WriteLine("=====================\n");
            Console.WriteLine(order1.GetPackingLabel());
            Console.WriteLine(order1.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order1.CalculateTotalCost()}\n");

            Console.WriteLine("\n\n");

            // Order 2 Summary Display:

            Console.WriteLine("Order 2:");
            Console.WriteLine("=====================\n");
            Console.WriteLine(order2.GetPackingLabel());
            Console.WriteLine(order2.GetShippingLabel());
            Console.WriteLine($"Total Cost: ${order2.CalculateTotalCost()}\n");
            
        }
    }

}