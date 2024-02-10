public class CheckListGoal : Goal
{
    private int _amountComplete;
    private int _target;
    private int _bonus;
    private bool _isComplete;

    public CheckListGoal(string name, string description, int points, int target, int bonus) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountComplete = 0;
        _isComplete = false;
    }

    public override void RecordEvent(List<Goal> _goals)
    {
        {
            _amountComplete++;
            if (_amountComplete == _target)
            {
                _points += _bonus;
                Console.WriteLine($"Congratulations! You have earned {_points} points!");
            }
        }

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        return $"[ ] {_shortName} ({_description} -- Currently completed: 0/{_target})";
    }
    public override string GetStringRepresentation()
    {
        return $"Check List Goal: {_shortName}, {_description}, {_points}, {_target}, {_bonus}";
    }
}