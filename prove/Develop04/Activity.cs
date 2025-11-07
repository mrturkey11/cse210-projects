using System.Transactions;

public class Activity
{
    protected float _durration;
    protected void SendMessage(string message, int durration)
    {
        Console.Write(message);
        if (durration > 0)
            Animation(durration);
    }

    protected void WelcomeMessage(string activity, string description)
    {
        Console.WriteLine($"Welcome to the {activity} Activity!");

        Console.WriteLine("");

        Console.WriteLine(description);

        Console.WriteLine("");

        CollectDurration();
    }
    
    protected void CollectDurration()
    {
        Console.Write("How long, in seconds, would you like your session? ");
        if (float.TryParse(Console.ReadLine(), out float durration))
            _durration = durration;
        else
        {
            Console.WriteLine("Enter a valid input");
            CollectDurration();
        }
    }

    public static int DisplayMenu()
    {
        // Write out the display
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Start breathing activity");
        Console.WriteLine("  2. Start reflecting activity");
        Console.WriteLine("  3. Start listing activity");
        Console.WriteLine("  4. Quit");
        // Recieve the input
        Console.Write("Select a choice from the menu: ");
        string input = Console.ReadLine();

        while (true){
            if (int.TryParse(input, out int result))
                return result;
            else
                Console.Write("Enter a valid input: ");
                input = Console.ReadLine();
                continue;
        }
    }

    protected void EndMessage(string activity, int index)
    {
        Console.WriteLine($"You have completed {_durration} seconds of the {activity} Activity!");
        Console.WriteLine($"You have now completed the {activity} Activity {Program.logs[index]} times!");
        Console.WriteLine("");
    }

    protected void Animation(int time)
    {
        // Disable cursor for neatness
        Console.CursorVisible = false;
        //Display intro message
        Console.Write("|");
        // Setup for animation
        string[] states = new string[] { "/", "-", "\\", "|" };
        for (int i = 0; i < time * 4; i++) // Loop animation
        {
            Console.Write("\b \b"); // Erase the previous charcacter
            Console.Write(states[i % states.Length]); // Replace it with the - character

            Thread.Sleep(250);
        }
        Console.Write("\b \b"); // Erase the animation
        // Renable the cursor for readabilty
        Console.CursorVisible = true;
    }
    protected void CountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--) // Loop animation
        {
            Console.Write("\b \b"); // Erase the previous charcacter
            Console.Write(i); // Replace it with the next number

            Thread.Sleep(1000);
        }
    }
}