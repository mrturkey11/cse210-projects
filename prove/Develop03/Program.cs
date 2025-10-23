using System;

class Program
{
    static Scripture scripture = new Scripture();
    static void Main(string[] args)
    {
        while (true)
        {
            scripture.DisplayScripture();
            scripture.HideLines();
            Console.WriteLine(" ");
            Console.WriteLine("Press Enter to continue or input Quit to exit the program");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
                break;
        }
    }
}