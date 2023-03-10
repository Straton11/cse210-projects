public class Swimming : Activity
{
    protected int laps;
    public Swimming(string _activityType, string _date, int _lenghtMinutes, double _distance, int _laps) : base(_activityType, _date, _lenghtMinutes, _distance)
    {
        laps = _laps;
    }
    public double CalculateDistance()
    {
        return (laps * 50) / 1000 * 0.62;
    }
    public override string GetSummary()
    {
        return $"Date: {GetDate()}, Activity: {activityType}, Minutes:({GetMinutes()}) Distance: {CalculateDistance().ToString("N2")} miles, Speed: {CalculateSpeed().ToString("N2")} mph, Pace: {CalculatePace().ToString("N2")} minutes/mile";
    }
}