using System;
using System.Data.Common;
using System.Net.Mail;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        // Opening line for the program.
        Console.Write("\nWelcome to the Journal Program!");

        // Create Blank variables run the menu loop.
        string userInput = "0";

        // Created a new instance of the PromptGenerator class  .
        PromptGenerator newPrompt = new PromptGenerator();

        // Create a new instance of the Journal class and begin it's entry list.
        Journal journal = new Journal();
        journal._entries = new List<Entry>();

        // Begin the loop for the menu they can select from.
        while (userInput != "6")
        {
            // Create a blank line to help with the visual look of our code in the terminal.
            Console.WriteLine("\n-------------------------");

            // Gives the user a menu of options they can select.
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write a New Entry");
            Console.WriteLine("2. Delete an Old Entry");
            Console.WriteLine("3. Display Open Journal");
            Console.WriteLine("4. Load a Saved Journal");
            Console.WriteLine("5. Save Open Journal");
            Console.WriteLine("6. Quit Journal Program");
            Console.Write("What would you like to do? ");
            userInput = Console.ReadLine();

            // Menu option = 1. Write a New Entry
            if (userInput == "1")
            {
                // Create a new list as a part of the PromptGenerator class.
                newPrompt._prompts = new List<string>();

                // Create a new instance of the Entry class.
                Entry entry = new Entry();

                // Pass the Prompt list we made to the random prompt method from the same class, and save it to the entry prompt text in the entry class.
                entry._promptText = newPrompt.GetRandomPrompt(newPrompt._prompts);

                // Display the random prompt for to the console for the user to reply to.
                Console.WriteLine(entry._promptText);
                Console.Write("> ");

                // Now we allow the user to respond to the prompt and we save their response to the entry text in the entry class.
                entry._entryText = Console.ReadLine();

                // Now we need to save the time that this entry was created before adding it to our journal entry list.
                entry._date = DateTime.Now.ToString("dd/M/yyyy");

                // Now we can add this new entry made (with date, prompt text, and entry text) to the Journal Entries list in the journal class using the journal AddEntry Method.
                journal.AddEntry(entry);
            }

            // *** Keep in mind this menu option is actually a whole new function not required by the assignment instructions and this EXCEEDS REQUIREMENTS. This allows the user to handle deleting duplicate entries or to get rid of faulty entries.
            // Menu option = 2. Delete an Old Entry
            else if (userInput == "2")
            {
                // List all of the entries for the user to see. 
                journal.DisplayAll();

                // Allow the user to pick a number number which represents the index of an entry to delete. 
                Console.WriteLine("\nLook at the list of entries displayed and pick the number associated with the entry you want to delete.");
                Console.WriteLine("Keep in mind that the number 1 matches the top of the list.");
                Console.Write("Number for Entry to delete: ");

                // Save their choice to a variable that we will use as an index to remove that entry from the _entries list.
                int indexToDelete = int.Parse(Console.ReadLine());
                
                // Now take their choice along with the _entries list and pass it along to the journal class to handle the deletion of this entry.
                journal.DeleteEntry(indexToDelete);
            }

            // Menu option = 3. Display Open Journal
            else if (userInput == "3")
            {
                // Will pull from the journal entry list, and use the entry class display method to display each entry.
                journal.DisplayAll();
            }

            // Menu option = 4. Load a Saved Journal
            else if (userInput == "4")
            {
                // Ask the user what file name they want to retrieve a journal from.
                Console.WriteLine("What is the filename of the journal you would like to open?");
                string fileName = Console.ReadLine();

                // Call to the LoadFromFile method from the Journal Class and save it to the _entries list to be viewed.
                journal.LoadFromFile(fileName);
            }

            // Menu option = 5. Save open Journal
            else if (userInput == "5")
            {
                // Ask the user for a file name that we will be saving our entries/journal to.
                Console.WriteLine("What is the filename you would like to save your Journal Entries to? ");
                string fileName = Console.ReadLine();

                // Call the SaveToFile method from the Journal Class and save it to the file path provided.
                journal.SaveToFile(fileName);
            }

            // Menu option = 6. Quit Journal Program
            else if (userInput == "6")
            {
                // Give some text in this option to mark that option 5 has been selected.
                Console.WriteLine("Closing Program...");
            }

            else 
            {
                // Will give this error if the user enters an invalid option for the menu selection.
                Console.WriteLine("Please enter a valid menu option.");
            }
        }
        // Final piece of code to nicely round out the program and let the user know we are done. 
        Console.WriteLine("\nCongratulations writing in your journal today!");
        Console.WriteLine("Come back again tomorrow!\n");
    }
}