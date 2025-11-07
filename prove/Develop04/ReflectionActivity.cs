using System.Data;

public class ReflectionActivity : Activity
{
    string[] _prompts = new string[4] { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };

    string[] _questions = new string[]
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };

    public void RunActivity()
    {
        // Print intro
        WelcomeMessage("Reflection", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life");

        Console.Clear();

        Console.WriteLine("Get Ready!");

        Animation(5);

        Console.WriteLine(""); // Create an empty line for neatness

        // Prompt User
        Random random = new Random();

        Console.WriteLine("Consider the following prompt:");

        Console.WriteLine("");

        Console.WriteLine($"-- {_prompts[random.Next(0,4)]} --");

        Console.WriteLine("");

        Console.WriteLine("When you have something in mind, press enter to continue");

        Console.ReadLine();

        Console.WriteLine("You may now ponder on each of the following questions as they are related to this experiance.");

        Console.Write("You may begin in: ");



        // Ask questions

        Console.Clear();

        Console.Write(_questions[random.Next(0, 9)]);

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_durration);

        DateTime now = start;

        Console.ReadKey(true);
        while (now < end)
        {
            now = DateTime.Now;

            // If Enter is pressed cycle to the next question
            if (Console.KeyAvailable == true)
            {
                Console.Write("\n");
                Console.ReadKey(true);
                Thread.Sleep(100);
                Console.Write(_questions[random.Next(0, 9)]);
            }
            else
                Animation(1);
        }

        EndMessage("Reflection", 0);
    }
}