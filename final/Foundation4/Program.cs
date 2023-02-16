using System;

class Program
{
    
    static void Main(string[] args)
    {
        
        DataBase database = new DataBase();
        bool play = true;
        Console.WriteLine();
        Console.WriteLine("Welcome to the Exercise Tracking App!");
        Console.WriteLine();
        do 
        {
            
            Console.WriteLine("Please choose one of the following actions:");
            Console.WriteLine("1. Add exercise");
            Console.WriteLine("2. Display summary");
            Console.WriteLine("3. Quit");
            Console.Write("What would you like to do?");
            string userInput = Console.ReadLine();
            int _switch = int.Parse(userInput);
            Console.WriteLine();
            
        
            switch(_switch)
            {
                case 1:
                    Console.Write("What exercise would you like to add?\n\r1. Running\n\r2. Stationary Bicycles\n\r3. Swimming laps\n\rType the number you want: ");
                    string option = Console.ReadLine();
                    Console.WriteLine();
                    if(option == "1")
                    {
                        string activityType = "Running";
                        
                        Console.Write("What is the Date of the activity? ");
                        string date = Console.ReadLine();
                        Console.Write("What is the length in minutes? ");
                        string userInput2 = Console.ReadLine();
                        int lenghtMinutes = int.Parse(userInput2);
                        Console.Write("What is the distance in miles? ");
                        string userInput3 = Console.ReadLine();
                        double distance = int.Parse(userInput3);
                        Running activity = new Running(activityType, date, lenghtMinutes, distance);
                        database.SetActivityList(activity);
                        Console.WriteLine();
                        
                        

                    }else if(option == "2")
                    {
                        string activityType = "Stationary Bicycles";
                        Console.Write("What is the Date of the activity? ");
                        string date = Console.ReadLine();
                        Console.Write("What is the length in minutes? ");
                        string userInput2 = Console.ReadLine();
                        int lenghtMinutes = int.Parse(userInput2);
                        Console.Write("What is the distance in miles? ");
                        string userInput3 = Console.ReadLine();
                        double distance = int.Parse(userInput3);
                        StationaryBicycles bikeActivity = new StationaryBicycles(activityType, date, lenghtMinutes, distance);
                        database.SetActivityList(bikeActivity);
                        Console.WriteLine();
                        
                        
                    }else if(option == "3")
                    {
                        string activityType = "Swimming";
                        Console.Write("What is the Date of the activity? ");
                        string date = Console.ReadLine();
                        Console.Write("What is the length in minutes? ");
                        string userInput2 = Console.ReadLine();
                        int lenghtMinutes = int.Parse(userInput2);
                        Console.Write("What is the number of laps? ");
                        string userInput3 = Console.ReadLine();
                        double laps = int.Parse(userInput3);
                    
                        Swimming swimmingActivity = new Swimming(activityType, date, lenghtMinutes, laps);
                        database.SetActivityList(swimmingActivity);
                        Console.WriteLine();

                    }

                    break;

                case 2:
                    Console.WriteLine("Summary:");
                    database.DisplayActivity();
                    Console.WriteLine();
                    break;

                case 3:
                    play = false;
                    break;

            }                      
        }while(play == true);  
    }
}