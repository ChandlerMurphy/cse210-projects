using System;

// Once you have created these classes, write a program that creates at least two orders with a 2-3 products each. 
// Call the methods to get the packing label, the shipping label, and the total price of the order, and 
// display the results of these methods.



class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Foundation2 World!");
        List<Order> orders = new List<Order>();

        Address address1 = new Address("1111 Street, 1 Blvd", "City 1", "State 1", "US");
        Customer customer1 = new Customer("Bob", address1);
        Order order1 = new Order(customer1);
        Product product1_1 = new Product("Slippers", "15243", 20, 2);
        Product product1_2 = new Product("Shoes", "15234", 25, 3);
        Product product1_3 = new Product("Back Pack", "51423", 50, 1);
        order1.AddProductToOrder(product1_1);
        order1.AddProductToOrder(product1_2);
        order1.AddProductToOrder(product1_3);
        orders.Add(order1);

        Address address2 = new Address("2222 Street, 2 Blvd", "City 2", "State 2", "EU");
        Customer customer2 = new Customer("Mark", address2);
        Order order2 = new Order(customer2);
        Product product2_1 = new Product("Marbles", "11432", 5, 15);
        Product product2_2 = new Product("Dog Toys", "55643", 15, 3);
        Product product2_3 = new Product("Gloves", "33312", 25, 2);
        order2.AddProductToOrder(product2_1);
        order2.AddProductToOrder(product2_2);
        order2.AddProductToOrder(product2_3);
        orders.Add(order2);

        foreach(Order order in orders)
        {
            Console.WriteLine("---------------------------\n");
            order.CreatePackingLabel();
            order.CreateShippingLabel();
            order.CalculateTotalOrderCost();
            Console.WriteLine("---------------------------");
        }
    }
}