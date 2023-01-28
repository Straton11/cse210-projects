using System.Diagnostics;
using System.Threading;

class BreathingActivity : Activity
{
    Spinner spinner = new Spinner();
    public int _time;
    public void GetMenu()
    {
        Console.WriteLine("\nWelcome to the Breathing Activity." + "\n" +
        "\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing." + "\n");
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
        spinner.Start(3);
        Breathing(_time);
    }

    public void Breathing(int time)
    {
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        int count = time;
        while (stopwatch.ElapsedMilliseconds / 1000 < time)
        {
            Console.Write("\nBreathe in...");
            for (int i = 4; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
            Console.Write("\nBreathe out...");
            for (int i = 6; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }

            Console.WriteLine(" ");
        }
        Console.WriteLine(" ");
        Console.WriteLine("Well done!!");
        spinner.Start(4);
        Console.WriteLine($"You have completed another {time} seconds of the Breathing Activity.");
        spinner.Start(4);
        Console.Clear();
    }
}