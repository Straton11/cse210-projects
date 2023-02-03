using System;

public class NegativeGoal : Goals
{
    public NegativeGoal(string goalName, string goalDescription, int goalPoints, string goalFinished): base(goalName,goalDescription,goalPoints,goalFinished)
    {

    }
    public override string GetGoalDetails()
    {
        return ($"[{_goalFinished}] {_goalName} ({_goalDescription})");
    }
}