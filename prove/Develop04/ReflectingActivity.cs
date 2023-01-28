using System.Diagnostics;
using System.Threading;

class ReflectingActivity : Activity
{

    Spinner spinner = new Spinner();
    public int _time;
    Prompts prompts;
    Promptz promptz;
    public ReflectingActivity()
    {
        prompts = new Prompts();
        promptz = new Promptz();
    }
    public void GetMenu()
    {
        Console.WriteLine("\nWelcome to the Reflecting Activity." + "\n" +
        "\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life." + "\n");
        Console.WriteLine(" ");
        Console.Write("How long, in seconds, would you like for your session? ");
        int time = Convert.ToInt16(Console.ReadLine());

        _time = time;
        Console.WriteLine("Get Ready...");
        spinner.Start(3);
    }

    public void Start()
    {
        GetMenu();
        Reflecting(_time);
    }

    private int Count;
    public void Reflecting(int time)
    {
        string prompt = prompts.RandomPrompt();
        Console.WriteLine("\n \n Consider the following prompt:\n \n ");
         Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine("\n \n When you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.Write("\n \n Now ponder on each of the following questions as they related to this experience." + "\n You may begin in: ");
        for (int i = 5; i >= 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
        }

        Console.Clear();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        while (stopwatch.ElapsedMilliseconds / 1000 < time)
        {
            string promptzz = promptz.RandomPrompt();
            Count++;
            switch (Count % 2)
            {
                case 0:
                    Console.WriteLine($">{promptzz}"); spinner.Start(5); break;
                case 1:
                    Console.WriteLine($">{promptzz}"); spinner.Start(5); break;

            }
        }
        Console.WriteLine(" ");
        Console.WriteLine("Well done!!");
        spinner.Start(4);
        Console.WriteLine($"You have completed another {time} seconds of the Reflecting Activity.");
        spinner.Start(4);
        Console.Clear();
    }
}
public class Prompts
{
    List<string> items = new List<string>() {"Think of a time when you stood up for someone else.", 
    "Think of a time when you did something really difficult.", 
    "Think of a time when you helped someone in need.", 
    "Think of a time when you did something truly selfless."};
    public string RandomPrompt()
    {
        
        Random question = new Random();
        int randomQuestion = question.Next(items.Count);
        string randomShow = items[randomQuestion];
        return randomShow;
    }

}
public class Promptz
{
    List<string> itemz = new List<string>() {"Why was this experience meaningful to you?", 
    "Have you ever done anything like this before?", 
    "How did you get started?", 
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};
    public string RandomPrompt()
    {
        
        Random question = new Random();
        int randomQuestion = question.Next(itemz.Count);
        string randomShow = itemz[randomQuestion];
        return randomShow;
    }

}