using System;
using System.Data.Common;
using System.Net.Mail;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop02 World!");

        // Opening line for the program
        Console.Write("\nWelcome to the Journal Program!");

        // Create Blank variables run the menu loop
        int userInput = 0;

        // Created a new instance of the PromptGenerator class  
        PromptGenerator newPrompt = new PromptGenerator();

        // Create a new instance of the Entry class 
        // Entry entry = new Entry();

        // Create a new instance of the Journal class and begin it's entry list
        Journal journal = new Journal();
        journal._entries = new List<Entry>();

        // Begin the loop for the menu they can select from
        while (userInput != 5)
        {
            // Create a blank line to help with the visual look of our code in the terminal 
            Console.WriteLine("\n-------------------------");

            // Gives the user a menu of options they can select
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            userInput = int.Parse(Console.ReadLine());

            // Menu option 1
            if (userInput == 1)
            {
                // Create a new list as a part of the PromptGenerator class
                newPrompt._prompts = new List<string>();

                // Create a new instance of the Entry class 
                Entry entry = new Entry();

                // Pass the Prompt list we made to the random prompt method from the same class, and save it to the entry prompt text in the entry class.
                entry._promptText = newPrompt.GetRandomPrompt(newPrompt._prompts);

                // Display the random prompt for to the console for the user to reply to
                Console.WriteLine(entry._promptText);
                Console.Write("> ");

                // Now we allow the user to respond to the prompt and we save their response to the entry text in the entry class
                entry._entryText = Console.ReadLine();

                // Now we need to save the time that this entry was created before adding it to our journal entry list.
                entry._date = DateTime.Now.ToString("dd/M/yyyy");

                // Now we can add this new entry made (with date, prompt text, and entry text) to the Journal Entries list in the journal class using the journal AddEntry Method
                journal.AddEntry(entry);
            }

            // Menu option 2
            else if (userInput == 2)
            {
                // Will pull from the journal entry list, and use the entry class disply method to display each entry.
                journal.DisplayAll();
            }

            // Menu option 3 *incomplete*
            // Allows the user to type in the name of the file they would like to load into the program and it will load it
            else if (userInput == 3)
            {
                Console.WriteLine("This is option 3");
            }

            // Menu option 4 *incomplete*
            // Will save the entries made or loaded into this session into a file destination provided
            else if (userInput == 4)
            {
                Console.WriteLine("This is option 4");
            }

            // Menu option 5
            else if (userInput == 5)
            {
                Console.WriteLine("Closing Program...");
            }

            else 
            {
                Console.WriteLine("Please enter a valid menu option.");
            }
        }

        Console.WriteLine("\nCongratulations writing in your journal today!");
        Console.WriteLine("Come back again tomorrow!\n");
    }
}