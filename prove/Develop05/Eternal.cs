using System.Text.Json.Serialization;

public class Eternal : Goal
{
    [JsonInclude] int completed { get; set; }

    public Eternal() {}

    public override void Display(bool listing)
    {
        // Write Goal information
        Console.WriteLine(listing ? $"[{completed}] {goal} ({description})" : $"{goal} ({description})");
    }

    public override void CreateGoal()
    {
        completed++;
        base.CreateGoal();
    }
}