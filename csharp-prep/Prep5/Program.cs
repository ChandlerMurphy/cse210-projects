using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep5 World!");

        static void DisplayMessage()
        {
            Console.WriteLine("\nWelcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter you name: ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter you favorite number: ");
            int userNumber = int.Parse(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int number)
        {
            int squareNumber = number * number;
            return squareNumber;
        }

        static void DisplayResult(string userName, int squareNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {squareNumber}");
        }

        DisplayMessage();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int squareNumber = SquareNumber(userNumber);
        DisplayResult(userName, squareNumber);

    }
}