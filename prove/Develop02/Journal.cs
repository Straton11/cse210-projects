using System.IO;
public class Journal
{
    List<Entry> answers;
    Prompts prompts;

    public Journal()
    {
        answers = new List<Entry>();
        prompts = new Prompts();
    }

    public void AddToEntries()
    {
        string prompt = prompts.RandomPrompt();
        string date = DateTime.Now.ToString("MM/dd/yyyy");
        Console.WriteLine(prompt);
        string eventResponse = Console.ReadLine();
        Entry answer = new Entry(prompt, eventResponse, date);
        answers.Add(answer);
    }

    public void DisplayList()
    {
        foreach (Entry answer in answers)
        {
            Console.WriteLine($"Date: {answer._date} - Prompt: {answer._prompts}\n{answer._response}");
            Console.WriteLine();
        }
    }
    public void Load(string file)
    {
        using (StreamReader read = new StreamReader(file))
        {
            String savedResponse = read.ReadToEnd();
            Console.WriteLine("\n" + savedResponse);
        }
    }

    public void Save(string file)
    {
        using (StreamWriter saveResponse = new StreamWriter(file, true))
        {
            foreach (Entry answer in answers)
            {
                saveResponse.WriteLine($"Date: {answer._date} - Prompt: {answer._prompts}\n{answer._response}");
                saveResponse.WriteLine();
            }
        }
    }
}
public class Prompts
{
    List<string> items = new List<string>() {"Who was the most interesting person I interacted with today?", 
    "What was the best part of my day?", 
    "How did I see the hand of the Lord in my life today?", 
    "What was the strongest emotion I felt today?",
    "If I had one thing I could do over today, what would it be?,",
    "What is something you are grateful for?",
    "What is your biggest fears?",
    "What surprised you today?",
    "What did you want to do today but were not able to?",
    "What happened today that was not ordinary?"};
    public string RandomPrompt()
    {
        
        Random question = new Random();
        int randomQuestion = question.Next(items.Count);
        string randomShow = items[randomQuestion];
        return randomShow;
    }

    public void SaveQuestion(string savedquestion)
    {
        items.Add(savedquestion);

    }
}
public class Trick
{
    public void trickAnswer(string trickQuestion)
    {
        if (trickQuestion == "Tomorrow")
        {
            Console.WriteLine("Awesome you got it");
        }
        else
        {
            Console.WriteLine("You got it wrong. The correct answer is Tomorrow!");
        }

    }
}