using System.Text.Json.Serialization;

public class Eternal : Goal
{
    [JsonInclude] int _completed { get; set; }

    public Eternal() {}

    public override void Display(bool listing)
    {
        // Write Goal information
        Console.WriteLine(listing ? $"[{_completed}] {_goal} ({_description})" : $"{_goal} ({_description})");
    }

    public override void CreateGoal()
    {
        _completed++;
        base.CreateGoal();
    }
}