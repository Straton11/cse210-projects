public class Saving 
{
    private List<Activity> activities = new List<Activity>();
    
    public void SetActivityList(Activity activity)
    {
        activities.Add(activity);
    }
    public void DisplayActivity()
    {
        foreach(Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}