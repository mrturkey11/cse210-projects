using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine(); 
        int percentage = int.Parse(input);
        char letterGrade;
        if (percentage >= 90)
            letterGrade = 'A';
        else if (percentage >= 80)
            letterGrade = 'B';
        else if (percentage >= 70)
            letterGrade = 'C';
        else if (percentage >= 60)
            letterGrade = 'D';
        else
            letterGrade = 'F';

        int secondDigit = int.Parse(input.Substring(1));
        string modifier = "";
        if (secondDigit >= 7)
            modifier = "+";
        else if (secondDigit <= 3)
            modifier = "-";
        bool exeptions = (modifier == "+" && letterGrade == 'A') || letterGrade == 'F';

        bool an = letterGrade == 'A' || letterGrade == 'F';
        string grammer = an ? "an" : "a";

        string message = percentage >= 70 ? "Congradulations you pass!" : "Mission failed we'll get 'em next time";
        Console.WriteLine($"Your letter grade is {grammer} {letterGrade}{(exeptions ? "" : modifier)}");
        Console.Write(message);
    }
}