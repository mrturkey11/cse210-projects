using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the program!");
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        int favoriteNumber = 3;
        Console.Write("Please enter your favorite number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
            favoriteNumber = number;
        else
            Console.WriteLine("Since you have refused to enter a valid number your favorite number is 3");

        Console.Write("Please enter the year you were born: ");
        int birthdate = 1984;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int dob))
            {
                birthdate = dob;
                break;
            }
            else
                Console.WriteLine("Enter a valid date");
        }
        Console.WriteLine($"{name}, the square of your number is {favoriteNumber * favoriteNumber}");
        Console.WriteLine($"{name}, you will turn {System.DateTime.Today.Year - birthdate} this year");
    }
}