using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep3 World!");

        string keepPlaying = "yes";
        int guessCount = 0;
        int userGuess = 0;

        while (keepPlaying == "yes")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1,101);

            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string ug = Console.ReadLine();
                userGuess = int.Parse(ug);
                guessCount = guessCount + 1;

                if (magicNumber < userGuess) 
                {
                    Console.Write("Lower");
                    Console.WriteLine("");
                }
                else if (magicNumber == userGuess)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine("");

                }
                else
                {
                    Console.Write("Higher");
                    Console.WriteLine("");
                }
            }
            Console.Write("Would you like to keep playing? ");
            keepPlaying = Console.ReadLine();
        }
        Console.WriteLine($"It took you {guessCount} guesses.");
        Console.WriteLine("Thank you for playing!");
    }
}