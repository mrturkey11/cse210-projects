using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);

        int guseses = 0;
        while (true)
        {
            int guess = 0;
            while (true)
            {
                Console.Write("What is your guess?: ");
                string guessString = Console.ReadLine();
                try
                {
                    guess = int.Parse(guessString);
                    break;
                }
                catch
                {
                    Console.WriteLine("Enter a valid number");
                    continue;
                }
            }

            guseses++;

            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed correctly!");
                Console.Write("Do you wish to play again? (y/n) ");
                string response = Console.ReadLine();

                // Reset variables
                magicNumber = random.Next(1, 101);
                guseses = 0;
                if (response.ToUpper() == "Y")
                    continue;
                else
                    break;
            }
            else
            {
                bool higher = guess > magicNumber;
                Console.WriteLine(higher ? "Lower" : "Higher");
            }
        }
    }
}