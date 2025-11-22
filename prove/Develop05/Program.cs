using System;
using System.Data;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Formats.Asn1;
class Program
{
    static List<Goal> goals { get; set; } = new List<Goal>();
    static int points;
    static void Main(string[] args)
    {
        while (true)
        {
            DisplayMenu();
            Console.WriteLine("");
            Console.WriteLine($"You have {points} points.");
            Console.WriteLine("");
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Shop");
        Console.WriteLine("7. Quit");
        Console.Write("Select a choice from the menu: ");

        int selection = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if(int.TryParse(input, out selection))
                break;
            else
                Console.Write("\n Enter a valid input: ");
        }
        // Recieve input
        switch (selection)
        {
            case(1):
                CreateGoal();
                return;
            case(2):
                DisplayGoals(true);
                return;
            case(3):
                Console.Write("Enter a name: ");
                string name = Console.ReadLine();
                Save(name);
                return;
            case(4):
                Console.Write("Enter a name: ");
                string file = Console.ReadLine();
                goals = Load(file);
                return;
            case(5):
                DisplayGoals(false);
                Console.Write("Which goal did you accomplish? ");
                int selected;
                while (true)
                {
                    string input = Console.ReadLine();
                    if(int.TryParse(input, out selected))
                        break;
                    else
                        Console.Write("\n Enter a valid input: ");
                }
                points += goals[selected - 1].GetPoints();            
                Console.WriteLine($"You now have {points} points.");

                return;
            case(6):
                Shop();
                return;
            case(7):
                Environment.Exit(0);
                return;
            default:
                DisplayMenu();
                return;
        }
    }
    static void Save(string name)
    {
        string directory = AppContext.BaseDirectory;
        string[] splits = directory.Split($"bin");
        string path = splits[0] + name;
        var fileText = JsonSerializer.Serialize(goals);
        File.WriteAllText(path, fileText);
    }
    static List<Goal> Load(string name)
    {
        string directory = AppContext.BaseDirectory;
        string[] splits = directory.Split($"bin");
        string path = splits[0] + name;
        var fileText = File.ReadAllText(path);
        return JsonSerializer.Deserialize<List<Goal>>(fileText);
    }
    static void Shop()
    {
        Console.WriteLine("You can buy: ");
        Console.WriteLine("1: Get yourself a treat(400p)");
        Console.WriteLine("2: Eat out for dinner(1000p)");
        Console.WriteLine("3: Buy yourself a game(2000p)");
        Console.Write("What will you do? ");

        int selection = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if(int.TryParse(input, out selection))
                break;
            else
                Console.Write("\n Enter a valid input: ");
        }
        if(selection == 1 && points >= 400)
            points -= 400;
        else if(selection == 2 && points >= 1000)
            points -= 1000;
        else if(selection == 3 && points >= 2000)
            points -= 2000;
        else
        {
            Console.WriteLine("Come back later!");
            return;
        }
        Console.WriteLine("Enjoy!");
    }
    static void DisplayGoals(bool list)
    {
        Console.WriteLine("The goals are: ");
        for(int i = 1; i < goals.Count + 1; i++)
        {
            Console.Write($" {i}.  ");
            goals[i - 1].Display(list);
        }
    }
    static void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create?: ");
        // Allow user to chose
        int selection = 0;
        while (true)
        {
            string input = Console.ReadLine();
            if(int.TryParse(input, out selection))
                break;
            else
                Console.Write("\n Enter a valid input: ");
        }
        // Recieve input
        switch (selection)
        {
            case(1):
                goals.Add(new Simple());
                goals[goals.Count - 1].CreateGoal();
                return;
            case(2):
                goals.Add(new Eternal());
                goals[goals.Count - 1].CreateGoal();
                return;
            case(3):
                goals.Add(new Checklist());
                goals[goals.Count - 1].CreateGoal();
                return;
            default:
                CreateGoal();
                return;
        }
    }
}