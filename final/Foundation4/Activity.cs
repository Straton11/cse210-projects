public class Activity
{
    protected string date, activityType;
    protected int lenghtMinutes;
    protected double distance;


    public Activity(string _activityType, string _date, int _lenghtMinutes, double _distance)
    {
        date = _date;
        lenghtMinutes = _lenghtMinutes;
        distance = _distance;
        activityType = _activityType;
    }
    public string GetDate()
    {
        return date;
    }
    public int GetMinutes()
    {
        return lenghtMinutes;
    }

    public double CalculateSpeed()
    {
        double pace = CalculatePace();
        double speed = 60 / pace;
        return speed;
    }
    public double CalculatePace()
    {
        
        double pace = lenghtMinutes / distance;
        return pace;
    }
    public virtual string GetSummary()
    {
        return $"°{date} {activityType} ({lenghtMinutes})-Distance {distance} miles, Speed: {CalculateSpeed().ToString("N2")} mph, Pace: {CalculatePace().ToString("N2")} min per mile";
    }
    
}