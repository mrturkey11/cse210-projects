using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        // Generate random number between 1 and 100 (max is not inclusive)
        int magicNumber = random.Next(1, 101);

        int guseses = 0;
        while (true)
        {
            int guess = 0;
            // Loop until guess is a valid integer
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

            //Check if guess is correct
            if (guess == magicNumber)
            {
                Console.WriteLine("You guessed correctly!");
                Console.Write("Do you wish to play again? (y/n) ");
                string response = Console.ReadLine();

                // Reset variables
                magicNumber = random.Next(1, 101);
                guseses = 0;
                if (response.ToUpper() == "Y")
                    continue; // Continue loop
                else
                    break; // Quit loop
            }
            else
            {
                // Give the use a clue
                bool higher = guess > magicNumber;
                Console.WriteLine(higher ? "Lower" : "Higher");
            }
        }
    }
}