public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int points)
    : base(name, desc, points)
    {

    }

    public override int RecordEvent()
    {
        return _points;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStatus()
    {
        return "[∞]";
    }

    public override string GetDetailsString()
    {
        return $"{GetStatus()} {_name} ({_description})";
    }

    public override string GetStringRepresentation()
    {
        return $"EternalGoal|{_name}|{_description}|{_points}";
    }

}
