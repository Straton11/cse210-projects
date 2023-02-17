using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Welcome to the Event Planning App!");
        Console.WriteLine();
        Console.WriteLine(" Lecture Event ");
        Console.WriteLine("---------------");
        Address address1 = new Address("Pevero", "Idaho Falls", "ID", "USA", 220, 83401);
        Lecture event1 = new Lecture("Lecture","Service Changes Lives","Come learn how serving others will change your life", "April 7th", "5:30 PM", address1, "Michael Wright", 250);
        Console.WriteLine("Standard Details:");
        Console.WriteLine(event1.StandarDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(event1.StandarDetails());
        Console.WriteLine(event1.GetFullDetails());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(event1.ShortDescription());
        Console.WriteLine();
        
        Console.WriteLine(" Reception Event ");
        Console.WriteLine("-----------------");
        Address address2 = new Address("Cornelison","Rexburg", "ID","USA",270,83440);
        Reception event2 = new Reception("Reception","James and Jessica's Reception","Come celebrate James and Jessica starting their life together","August 28th 2023","6:00 PM",address2,"jessica@yahoo.com");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(event2.StandarDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(event2.StandarDetails());
        Console.WriteLine(event2.GetEmail());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(event2.ShortDescription());
        Console.WriteLine();


        Console.WriteLine(" Outdoor Gathering Event ");
        Console.WriteLine("-------------------------");
        Address address3 = new Address("Thang Lo","Sigon","AO","Vietnam",41,55569);
        OutdoorGathering event3 = new OutdoorGathering("Outdoor Gathering","Tet New Year Party", "Celebrate the New Year with a bang", "December 31 2023", "11:00PM",address3,"Slightly chilly, bring jacket");
        Console.WriteLine("Standard Details:");
        Console.WriteLine(event3.StandarDetails());
        Console.WriteLine();
        Console.WriteLine("Full Details:");
        Console.WriteLine(event3.StandarDetails());
        Console.WriteLine(event3.GetWeather());
        Console.WriteLine();
        Console.WriteLine("Short Description:");
        Console.WriteLine(event3.ShortDescription());
        Console.WriteLine();


    }
}