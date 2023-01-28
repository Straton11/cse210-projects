using System.Diagnostics;
using System.Threading;

class listingActivity : Activity
{
    Spinner spinner = new Spinner();
    public int _time;

    Prompt prompts;
    public listingActivity()
    {
        prompts = new Prompt();
    }
    public void GetMenu()
    {
        Console.WriteLine("\nWelcome to the listing Activity." + "\n" +
        "\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area." + "\n");
        Console.WriteLine(" ");
        Console.Write("How long, in seconds, would you like for your session? ");
        int time = Convert.ToInt16(Console.ReadLine());

        _time = time;
    }

    public void Start()
    {
        GetMenu();
        spinner.Start(3);
        listing(_time);
    }

    public void listing(int time)
    {
        string prompt = prompts.RandomPrompt();
        Console.WriteLine("Get Ready...");
        spinner.Start(3);

        Console.Write("List as many responses you can to the following prompt: \n");
        Console.Write($"{prompt}");
        Console.Write("\nYou may begin in: ");
        for (int i = 5; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

        Console.Clear();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        List<string> list = new List<string>();

        while (stopwatch.ElapsedMilliseconds / 1000 < time)
        {
            Console.Write("> ");
            string addItem = Console.ReadLine();
            list.Add(addItem);

        }
        Console.WriteLine($"You listed: {list.Count} items.");
        spinner.Start(4);
        Console.WriteLine(" ");
        Console.WriteLine("Well done!!");
        spinner.Start(4);
        Console.WriteLine($"You have completed another {time} seconds of the Listing Activity.");
        spinner.Start(4);
        Console.Clear();
    }
}
public class Prompt
{
    List<string> item = new List<string>() {"Who are people that you appreciate?", 
    "What are personal strengths of yours?", 
    "Who are people that you have helped this week?", 
    "When have you felt the Holy Ghost this month?",
    "Who are some of your personal heroes?"};
    public string RandomPrompt()
    {
        
        Random question = new Random();
        int randomQuestion = question.Next(item.Count);
        string randomShow = item[randomQuestion];
        return randomShow;
    }

}