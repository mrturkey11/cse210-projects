public class Journal
{
    public List<Entry> entries { get; set; } = new List<Entry>();

    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(" ");
            entry.DisplayEntry();
        }
    }
}