using System;
using System.Diagnostics;
using System.Threading;
class Activity
{
    protected string _message = "";
    protected string _description = "";
    protected string _endingMessage = "";

    private List<int> _usedPrompts = new List<int>();


    public string GetMessage()
    {
        return _message;
    }
    public string GetDescription()
    {
        return _description;
    }

    public string GetEndingMessage()
    {
        return _endingMessage;
    }
   


    public void SetActivityData(string message, string description, string endingMessage)
    {
        _message = message;
        _description = description;

        _endingMessage = endingMessage;
    }
}
class Menu
{
    public static void displayMenu()
    {
        int numberOfActivities = 0;
        Message message = new Message();
        String response = null;

        message.SetMessage("\n Menu Options:" +
    "\n     1. Start breathing activity" +
    "\n     2. Start reflecting activity" +
    "\n     3. Start listing activity" +
    "\n     4. quit" +
    "\n Select a choice from the menu: ");
        do
        {
            Console.WriteLine(message.GetMessage());

            response = Console.ReadLine();
            switch (response)
            {
                case "1":


                    BreathingActivity activity = new BreathingActivity();
                    activity.SetActivityData("Message", "String", "Ending Message");
                    activity.Start();
                    numberOfActivities += 1;
                    break;
                case "2":
                    ReflectingActivity act2 = new ReflectingActivity();
                    act2.SetActivityData("Message", "String", "Ending Message");
                    act2.Start();
                    numberOfActivities += 1;
                    break;
                case "3":
                    listingActivity act3 = new listingActivity();
                    act3.SetActivityData("Message", "String", "Ending Message");
                    act3.Start();
                    numberOfActivities += 1;
                    break;
                case "4":
                    Console.WriteLine($"You did a total of {numberOfActivities} activities this session.");
                    Console.WriteLine("Thank you for using the Mindfulness Program!");
                    break;
                default:
                    Console.WriteLine("Please choose a valid option.");
                    break;
            }
        } while (response != "4");
    }
}
class Message
{
    private string _message = "";

    public string GetMessage()
    {
        return _message;
    }

    public void SetMessage(string message)
    {
        _message = message;
    }
}

class Spinner
{
    private int SpinnerCount = 0;

    public void Start(int time)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        while (stopwatch.ElapsedMilliseconds / 1000 < time)
        {
            SpinnerCount++;
            switch (SpinnerCount % 4)
            {
                case 0: Console.Write("/"); break;
                case 1: Console.Write("-"); break;
                case 2: Console.Write("\\"); break;
                case 3: Console.Write("|"); break;
            }
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            Thread.Sleep(340);
        }
        Console.Write(" ");
    }
}