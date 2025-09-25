using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        while (true)
        {
            Console.Write("Enter a number: ");
            try
            {
                int number = int.Parse(Console.ReadLine());
                if (number == 0)
                    break;
                numbers.Add(number);
            }
            catch
            {
                Console.WriteLine("Enter a valid number");
            }
        }
        int sum = 0;
        int largestNumber = -9999;
        int lowestPositive = 9999;
        for (int i = 0; i < numbers.Count; i++)
        {
            sum += numbers[i];
            if (numbers[i] > largestNumber)
                largestNumber = numbers[i];
            if (numbers[i] < lowestPositive && numbers[i] > 0)
                lowestPositive = numbers[i];
        }
        Console.WriteLine("The sum is: " + sum);
        Console.WriteLine("The average is: " + sum / numbers.Count);
        Console.WriteLine("The highest number is: " + largestNumber);
        Console.WriteLine("The smallest positive number is: " + lowestPositive);
        Console.WriteLine("The sorted list is: ");
        numbers.Sort();
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}