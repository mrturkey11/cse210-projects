public class Entry
{
    public string entry { get; set; }
    public DateTime dateTime { get; set; }
    public string prompt { get; set; }
    public Entry()
    {
        // Get Prompt
        Console.Write("Todays Prompt is: ");
        prompt = Prompts.GetPrompt();
        Console.WriteLine(prompt);
        // Record Entry
        Console.WriteLine("----------");
        entry = Console.ReadLine();
        // Store DateTime
        dateTime = System.DateTime.Now;
        // Debug Status
        Console.WriteLine("Entry Recorded");
    }
    public void DisplayEntry()
    {
        Console.WriteLine($"Date: {dateTime.ToString("dd/mm/yyyy")}");
        Console.WriteLine($"Prompt: {prompt}");
        Console.WriteLine("----------");
        Console.WriteLine(entry);
    }
}