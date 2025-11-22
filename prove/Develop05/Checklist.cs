using System.Text.Json.Serialization;

public class Checklist : Goal
{
    [JsonInclude] int _todo { get; set; }
    [JsonInclude] int _completed { get; set; }
    [JsonInclude] int _bonus { get; set; }
    public Checklist() {}

    public override void Display(bool listing)
    {
        // Write Goal information
        Console.WriteLine(listing ? $"[{_completed}/{_todo}] {_goal} ({_description})" : $"{_goal} ({_description})");
    }

    public override void CreateGoal()
    {
        base.CreateGoal();

        Console.Write("How many times does this need to be accomplished for a bonus? ");
        
        _todo = GetInt();

        Console.Write("What is the bonus for acomplishing it that many times? ");

        _bonus = GetInt();
    }

    public override int GetPoints()
    {
        _completed++;
        if(_todo <= _completed)
        {
            Console.WriteLine($"Congratulations! You met your goal and earned {_bonus} points!");
            return _bonus;
        }
        else
        {
            Console.WriteLine($"Congratulations! You earned {_points} points!");
            return _points;
        }
    }
}