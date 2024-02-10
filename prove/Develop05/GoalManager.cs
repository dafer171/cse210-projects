public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public GoalManager()
    {
        _score = 0;
    }

    public void Start()
    {

    }
    public int GetTotalPoints()
    {
        return _score;
    }
    public void AddPoints(int points)
    {
        _score += points;
    }
    public void DisplayPlayerInfo()
    {

    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetGoalName()}");
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("List of Goals:");
        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }

    }

    public void CreateGoal()
    {
        List<string> goals = new List<string>
        {
            "1. Simple Goal",
            "2. Eternal Goal",
            "3. Checklist Goal"
        };
        int userAction = 0;

        Console.WriteLine("The types of Goals are: ");
        foreach (string goal in goals)
        {
            Console.WriteLine(goal);
        }
        Console.Write("Which type of goal you like to create? ");

        userAction = int.Parse(Console.ReadLine());

        if (userAction == 1)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            SimpleGoal s1 = new SimpleGoal(name, description, points);
            _goals.Add(s1);
        }

        if (userAction == 2)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            EternalGoal e1 = new EternalGoal(name, description, points);
            _goals.Add(e1);
        }

        if (userAction == 3)
        {
            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            int points = int.Parse(Console.ReadLine());

            Console.Write("How many times does this goal need to be accomplised for a bonus? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());

            CheckListGoal c1 = new CheckListGoal(name, description, points, target, bonus);
            _goals.Add(c1);
        }
    }

    public void RecordEvent()
    {
        Console.Write("Which goal did you acomplish? ");
        int userSelectionGoal = int.Parse(Console.ReadLine()) - 1;

        int goalPoints = _goals[userSelectionGoal].GetPoints();
        AddPoints(goalPoints);

        _goals[userSelectionGoal].RecordEvent(_goals);

        Console.WriteLine($"\nYou have {GetTotalPoints()} points!");

    }
    public void SaveGoals()
    {
        {
            Console.Write("What is the filename for the goal file? ");
            string fileName = Console.ReadLine();

            using (StreamWriter outFile = new StreamWriter(fileName))
            {
                foreach (Goal goal in _goals)
                {
                    outFile.WriteLine(goal.GetStringRepresentation());
                }
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string type = parts[0];
            string representation = parts[1];

            if (type == "Simple Goal")
            {
                string[] details = representation.Split(",");
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                SimpleGoal simpleGoal = new SimpleGoal(name, description, points);
                _goals.Add(simpleGoal);
            }
            if (type == "Eternal Goal")
            {
                string[] details = representation.Split(",");
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                EternalGoal eternalGoal = new EternalGoal(name, description, points);
                _goals.Add(eternalGoal);
            }
            if (type == "Check List Goal")
            {
                string[] details = representation.Split(",");
                string name = details[0];
                string description = details[1];
                int points = int.Parse(details[2]);
                int target = int.Parse(details[3]);
                int bonus = int.Parse(details[4]);

                CheckListGoal checkListGoal = new CheckListGoal(name, description, points, target, bonus);
                _goals.Add(checkListGoal);
            }
        }

    }
}