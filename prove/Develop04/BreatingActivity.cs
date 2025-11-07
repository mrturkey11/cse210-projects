public class BreathingActivity : Activity
{
    public void RunActivity()
    {
        // Print intro
        WelcomeMessage("Breathing" ,"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing");

        Console.Clear();

        Console.WriteLine("Get Ready!");

        Animation(5);

        Console.WriteLine(""); // Create an empty line for neatness

        // Activity
        Console.CursorVisible = false;
        for (int x = 0; x < (int)(_durration / 5); x++)
        {
            if (x % 2 == 0)
            {
                Console.WriteLine("");
                Console.Write("Breath in...");
            }
            else
                Console.Write("Breaath Out...");
            CountDown(5);
            Console.Write("\b \b \n"); // Erase the number and break line
        }
        Console.CursorVisible = true;

        Console.WriteLine("");

        EndMessage("Breathing", 0);
    }
}