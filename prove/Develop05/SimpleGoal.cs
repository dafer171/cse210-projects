public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points) : base(name, description, points)
    {
        _isComplete = false;
    }

    public override void RecordEvent(List<Goal> _goals)
    {
        _isComplete = true;
        Console.WriteLine($"Congratulations! You have earned {GetPoints()} points!");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Simple Goal: {_shortName}, {_description}, {_points}, {_isComplete}";
    }

}