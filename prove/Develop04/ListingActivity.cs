public class ListingActivity : Activity
{
    string[] _questions = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    public void RunActivity()
    {
        // Print intro
        WelcomeMessage("Listing" ,"This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area");

        Console.Clear();

        Console.WriteLine("Get Ready!");

        Animation(5);

        Console.WriteLine(""); // Create an empty line for neatness

        // Activity
        Random random = new Random();

        Console.WriteLine(_questions[random.Next(0, 5)]);
        Console.WriteLine("");

        int counter = 0;
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_durration);

        DateTime now = start;

        Console.ReadKey(true);
        while (now < end)
        {
            now = DateTime.Now;

            // If Enter is pressed cycle to the next question
            if (Console.ReadLine() != null)
            {
                Console.Write("\n");
                counter++;
            }
        }

        Console.WriteLine("");

        Console.WriteLine($"You entered {counter} items, congratulations!");
        
        Console.WriteLine("");

        EndMessage("Listing", 0);
    }
}