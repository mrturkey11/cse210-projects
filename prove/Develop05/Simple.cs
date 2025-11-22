using System.Text.Json.Serialization;

public class Simple : Goal
{
    [JsonInclude] bool _completed{ get; set; }

    public Simple() {}

    public override void Display(bool listing)
    {
        // Write Goal information
        string completedMark = _completed ? "X" : " ";
        Console.WriteLine(listing ? $"[{completedMark}] {_goal} ({_description})" : $"{_goal} ({_description})");
    }
    public override int GetPoints()
    {
        _completed = true;
        return base.GetPoints();
    }
}