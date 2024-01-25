using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        // Create starting variables and Class instances
        string userInput = "";
        Reference reference = new Reference("book", 1, 2, 3);
        Scripture scripture = new Scripture(reference, "test");

        // Create a while loop that runs the program until the user quits or the scripture being memorized is all hidden.
        while (userInput != "quit" && true != scripture.IsCommpletelyHidden())
        {
            // This will clear the console after the user types their choice.
            Console.Clear();

            // Call the "GetDisplayText()" method from the reference class to display the scripture reference.
            Console.WriteLine(reference.GetDisplayText());

            // Create a note to the console that tells the user their options for running the program.
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        
            // Read the user input into a variable.
            userInput = Console.ReadLine();
        }
    }
}