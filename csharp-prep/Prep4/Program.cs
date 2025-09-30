using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Initialize list
        List<int> numbers = new List<int>();
        // Loop until a break
        while (true)
        {
            // Ensure input is a valid integer
            Console.Write("Enter a number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                    break;
                numbers.Add(number); // Add number to list
            }
            catch
            {
                Console.WriteLine("Enter a valid number");
            }
        }
        // Initilize variables for calculations
        int sum = 0;
        int largestNumber = -9999;
        int lowestPositive = 9999;
        // Find highest and lowest numbers
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers[i] > largestNumber)
                largestNumber = numbers[i];
            if (numbers[i] < lowestPositive && numbers[i] > 0)
                lowestPositive = numbers[i];
        }
        // Print outputs
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + sum / numbers.Count);
        Console.WriteLine("The highest number is: " + largestNumber);
        Console.WriteLine("The smallest positive number is: " + lowestPositive);
        Console.WriteLine("The sorted list is: ");
        // Sort list
        numbers.Sort();
        foreach (var number in numbers)
        {
            Console.WriteLine(number); // Write sorted list
        }
    }
}