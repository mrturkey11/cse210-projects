using System;

class Program
{
    static Journal journal = new Journal();
    static SaveLoad saveLoad = new SaveLoad();
    
    static void Main(string[] args){
        DisplayMenu();
    }

    static void DisplayMenu()
    {
        while (true)
        {
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int number))
            {
                if (number == 1)
                    journal.entries.Add(new Entry());
                else if (number == 2)
                    journal.DisplayEntries();
                else if (number == 3)
                    journal = saveLoad.Load();
                else if (number == 4)
                    saveLoad.Save(journal);
                else if (number == 5)
                    break;
            }
            Console.WriteLine(" ");
        }
    }
}