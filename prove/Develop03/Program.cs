using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        // Create starting variables and Class instances
        string userInput = "";
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the Lord with all thine heart and lean not on thine own understanding; in all thy ways acknowledge him, and he shall direct thy paths.");

        // Create a while loop that runs the program until the user quits or the scripture being memorized is all hidden.
        while (userInput != "quit" && true != scripture.IsCommpletelyHidden())
        {
            // This will clear the console after the user types their choice.
            Console.Clear();

            // Call the Scripture class method to hide pieces of the string before displaying the (hide three at a time).
            scripture.HideRandomWords(3); 

            // Call the "GetDisplayText()" method from the scripture class to display the scripture reference and text.
            scripture.GetDisplayText();

            // Create a note to the console that tells the user their options for running the program.
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        
            // Read the user input into a variable.
            userInput = Console.ReadLine();
        }
    }
}