using System.Text.Json.Serialization;

public class Simple : Goal
{
    [JsonInclude] bool completed{ get; set; }

    public Simple() {}

    public override void Display(bool listing)
    {
        // Write Goal information
        string completedMark = completed ? "X" : " ";
        Console.WriteLine(listing ? $"[{completedMark}] {goal} ({description})" : $"{goal} ({description})");
    }
    public override int GetPoints()
    {
        completed = true;
        return base.GetPoints();
    }
}