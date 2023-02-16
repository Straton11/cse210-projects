using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Online Ordering App!");
        Console.WriteLine();
//first person to order
        Address address1 = new Address("Hansen", "Idaho Falls", "ID","USA");
        Customer customer1 = new Customer("Lottie Lee", address1);
        Order order1 = new Order(customer1);
        Product product11 = new Product("Dipers", 35483290, 20, 2);
        Product product12 = new Product("Wipes", 45398590, 1.50, 8);
        order1.SetProducts(product11);
        order1.SetProducts(product12);
        
        
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



//second persond to order
        Address address2 = new Address("Pevero", "Sau Paulo", "BZ","Brazil");
        Customer customer2 = new Customer("Houston Facer", address2);
        Order order2 = new Order(customer2);
        Product product21 = new Product("Book of Mormon", 34432290, 5, 20);
        Product product22 = new Product("Notebook", 23458912, 2, 6);
        Product product23 = new Product("Pens", 65123975, 1, 25);
        order2.SetProducts(product21);
        order2.SetProducts(product22);
        order2.SetProducts(product23);
        
        
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



//third person to order
        Address address3 = new Address("Cornelison", "Rexburg", "ID","USA");
        Customer customer3 = new Customer("Dillon Merril", address3);
        Order order3 = new Order(customer3);
        Product product31 = new Product("Nike Socks", 21346721, 7, 10);
        Product product32 = new Product("Pants", 45646721, 5, 7);
        order3.SetProducts(product31);
        order3.SetProducts(product32);


        
        
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
// Here is the final of foundation 2