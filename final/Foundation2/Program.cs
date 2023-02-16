using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Online Ordering App!");
        Console.WriteLine();
        Address order1A = new Address("Hansen", "Idaho Falls", "ID","USA");
        Customer order1C = new Customer("Lottie Lee", order1A);
        Order order1 = new Order(order1C);
        Product order1P1 = new Product("Dipers", 35483290, 20, 2);
        Product order1P2 = new Product("Wipes", 45398590, 1.50, 8);
        order1.SetProducts(order1P1);
        order1.SetProducts(order1P2);
        
        
        Console.WriteLine("ORDER: 1");
        Console.WriteLine ("Packing Label:");
        order1.PackingLabel();
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        order1.ShippingLabel();
        Console.WriteLine();
        double totalPrice = order1.TotalCostProducts();
        Console.WriteLine($"      Total price: ${totalPrice}      ");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();




        Address order2A = new Address("Pevero", "Sau Paulo", "BZ","Brazil");
        Customer order2C = new Customer("Houston Facer", order2A);
        Order order2 = new Order(order2C);
        Product order2P1 = new Product("Book of Mormon", 34432290, 5, 20);
        Product order2P2 = new Product("Notebook", 23458912, 2, 6);
        Product order2P3 = new Product("Pens", 65123975, 1, 25);
        order2.SetProducts(order2P1);
        order2.SetProducts(order2P2);
        order2.SetProducts(order2P3);
        
        
        Console.WriteLine("ORDER: 2");
        Console.WriteLine ("Packing Label:");
        order2.PackingLabel();
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        order2.ShippingLabel();
        Console.WriteLine();
        double totalPrice2 = order2.TotalCostProducts();
        Console.WriteLine($"     Total price: ${totalPrice2}      ");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();




        Address order3A = new Address("Cornelison", "Rexburg", "ID","USA");
        Customer order3C = new Customer("Dillon Merril", order3A);
        Order order3 = new Order(order3C);
        Product order3P1 = new Product("Nike Socks", 21346721, 7, 10);
        Product order3P2 = new Product("Pants", 45646721, 5, 7);
        order3.SetProducts(order3P1);
        order3.SetProducts(order3P2);


        
        
        Console.WriteLine("ORDER: 3");
        Console.WriteLine ("Packing Label:");
        order3.PackingLabel();
        Console.WriteLine();
        Console.WriteLine("Shipping Label:");
        order3.ShippingLabel();
        Console.WriteLine();
        double totalPrice3 = order3.TotalCostProducts();
        Console.WriteLine($"     Total price: ${totalPrice3}      ");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine();



    }
}