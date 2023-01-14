public class Entry
{
    public string _prompts;
    public string _response;
    public string _date;

    public Entry(string prompt, string response, string date)
    {
        _prompts = prompt;
        _response = response;
        _date = date;
    }
}