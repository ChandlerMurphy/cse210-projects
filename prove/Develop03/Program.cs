using System;


// My programm meets all the core requirements. It exceeds them by the additon of the ScriptureGenerator class I added. 
// This class randomly gives the program some scriptures to display for the user to memorize. It also follows the rules of encapsulation as taught in class this week. 

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop03 World!");

        // Create starting variables and Class instances
        string userInput = "";
        ScriptureGenerator scriptureGenerator = new ScriptureGenerator();

        // Call the GetRandomNumber method and save the number to a variable becasue we need to pass the exact number to two methods.
        int number = scriptureGenerator.GetRandomNumber();

        // Create a new Reference class instance calling the GetRandomReference() method because it returns a reference object.
        Reference Reference = scriptureGenerator.GetRandomReference(number);

        // Create a new Scripture class reference and use its constructor to make a Scripture object.
        Scripture scripture = new Scripture(Reference, scriptureGenerator.GetRandomScripture(number));

        // Create a while loop that runs the program until the user quits or the scripture being memorized is all hidden.
        while (userInput != "quit" && true != scripture.IsCommpletelyHidden())
        {
            // This will clear the console after the user types their choice.
            Console.Clear();

            // Call the Scripture class method to hide pieces of the string before displaying the (hide three at a time).
            scripture.HideRandomWords(); 

            // Call the "GetDisplayText()" method from the scripture class to display the scripture reference and text.
            scripture.GetDisplayText();

            // Create a note to the console that tells the user their options for running the program.
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
        
            // Read the user input into a variable.
            userInput = Console.ReadLine();
        }
    }
}