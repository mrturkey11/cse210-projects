using System.Text.Json.Serialization;

public class Checklist : Goal
{
    [JsonInclude] int todo { get; set; }
    [JsonInclude] int completed { get; set; }
    [JsonInclude] int bonus { get; set; }
    public Checklist() {}

    public override void Display(bool listing)
    {
        // Write Goal information
        Console.WriteLine(listing ? $"[{completed}/{todo}] {goal} ({description})" : $"{goal} ({description})");
    }

    public override void CreateGoal()
    {
        base.CreateGoal();

        Console.Write("How many times does this need to be accomplished for a bonus? ");
        
        todo = GetInt();

        Console.Write("What is the bonus for acomplishing it that many times? ");

        bonus = GetInt();
    }

    public override int GetPoints()
    {
        completed++;
        if(todo <= completed)
        {
            Console.WriteLine($"Congratulations! You met your goal and earned {bonus} points!");
            return bonus;
        }
        else
        {
            Console.WriteLine($"Congratulations! You earned {points} points!");
            return points;
        }
    }
}