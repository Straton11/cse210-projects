using System;

class Program
{
    
    static void Main(string[] args)
    {
        
        Saving saving = new Saving();
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
                    Console.Write("What exercise would you like to add?\n\r1. Running\n\r2. Stationary Bicycles\n\r3. Swimming Laps\n\rType the number you want: ");
                    string choice = Console.ReadLine();
                    Console.WriteLine();
                    if(choice == "1")
                    {
                        string activityType = "Running";
                        
                        Console.Write("What is the Date of the activity (month-day)? ");
                        string date = Console.ReadLine();
                        Console.Write("What is the length in minutes? ");
                        string number2 = Console.ReadLine();
                        int lenghtMinutes = int.Parse(number2);
                        Console.Write("What is the distance in miles? ");
                        string number3 = Console.ReadLine();
                        double distance = int.Parse(number3);
                        Running running = new Running(activityType, date, lenghtMinutes, distance);
                        saving.SetActivityList(running);
                        Console.WriteLine();
                        
                        

                    }else if(choice == "2")
                    {
                        string activityType = "Stationary Bicycles";
                        Console.Write("What is the Date of the activity (month-day)? ");
                        string date = Console.ReadLine();
                        Console.Write("What is the length in minutes? ");
                        string number2 = Console.ReadLine();
                        int lenghtMinutes = int.Parse(number2);
                        Console.Write("What is the distance in miles? ");
                        string number3 = Console.ReadLine();
                        double distance = int.Parse(number3);
                        StationaryBicycles stationaryBicycles = new StationaryBicycles(activityType, date, lenghtMinutes, distance);
                        saving.SetActivityList(stationaryBicycles);
                        Console.WriteLine();
                        
                        
                    }else if(choice == "3")
                    {
                        string activityType = "Swimming";
                        Console.Write("What is the Date of the activity (month-day)? ");
                        string date = Console.ReadLine();
                        Console.Write("What is the length in minutes? ");
                        string number2 = Console.ReadLine();
                        int lenghtMinutes = int.Parse(number2);
                        Console.Write("What is the number of laps (has to be greater than 20 laps to calculate)? ");
                        string number3 = Console.ReadLine();
                        int laps = int.Parse(number3);
                        double distance = laps * 50 / 1000 * 0.62 ;
                    
                        Swimming swimming = new Swimming(activityType, date, lenghtMinutes, distance, laps);
                        saving.SetActivityList(swimming);
                        Console.WriteLine();

                    }

                    break;

                case 2:
                    Console.WriteLine("Summary:");
                    saving.DisplayActivity();
                    Console.WriteLine();
                    break;

                case 3:
                    play = false;
                    break;

            }                      
        }while(play == true);  
    }
}