using System;

class Program
{
    static void Main(string[] args)
    {
        //Here just making the consolve look how I want it to.
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Clear();

        Console.WriteLine("Welcome to the Journal Program!");
        Journal app = new Journal();
        Prompts savedquestion = new Prompts();
        Trick trick = new Trick();
        bool go = true;
        while (go)
        { 
            Console.WriteLine("Please select one of the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Answer a trick question\n6. Quit\nWhat would you like to do?");
            int input = int.Parse(Console.ReadLine());
            //Here is the menu that will switch between each of the users input until the user ends it. 
            switch (input)
            {
                case 1:
                    app.AddToEntries();
                    Console.WriteLine();
                    break;
                case 2:
                    app.DisplayList();
                    break;
                case 3:
                    Console.WriteLine("What is the filename?");
                    string file = Console.ReadLine();
                    app.Load(file);
                    break;
                case 4:
                    Console.WriteLine("What is the filename?");
                    string newfile = Console.ReadLine();
                    app.Save(newfile);
                    Console.WriteLine();
                    break;

                case 5:
                //Here is something a little extra and fun to try and guess. 
                    Console.WriteLine("What is always coming but never arrives?");
                    string trickQuestion = Console.ReadLine();
                    trick.trickAnswer(trickQuestion);
                    Console.WriteLine();
                    break;

                case 6:
                    go = false;
                    Console.WriteLine("Thanks for using the Journal App.");
                    break;

                default:
                    Console.WriteLine("Please choose a number between 1 and 6.");
                    break;
            }
        }
    }
}
/*Things that I did to exceed the requirements were adding 5 more prompts to the list. 
Then I made it so the console background was blue and the text was red just to make it look different.
The last thing that I did to make it my own was added my own little trick question to make
it a fun little guessing game.*/