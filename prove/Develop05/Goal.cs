using System.Text.Json.Serialization;

[JsonDerivedType(typeof(Simple), typeDiscriminator: "simple")]
[JsonDerivedType(typeof(Eternal), typeDiscriminator: "eternal")]
[JsonDerivedType(typeof(Checklist), typeDiscriminator: "checklist")]
public abstract class Goal
{
    [JsonInclude] protected string goal { get; set; }
    [JsonInclude] protected string description { get; set; }
    [JsonInclude] protected int points { get; set; }
    public abstract void Display(bool listing);
    public virtual void CreateGoal()
    {
        // Get basic inputs
        Console.Write("What is the name of your goal? ");
        goal = Console.ReadLine();
        Console.Write("What is a short description of your goal? ");
        description = Console.ReadLine();
        Console.Write("What is the ammount of points associated goal? ");
        points = GetInt();
    }

    public virtual int GetPoints()
    {
        Console.WriteLine($"Congratulations! You earned {points} points!");
        return points;
    }

    public int GetInt()
    {
        int output;
        while (true)
        {
            string input = Console.ReadLine();
            if(int.TryParse(input, out output))
                break;
            else
                Console.WriteLine("\n Enter a valid input: ");
        }
        return output;
    }
}