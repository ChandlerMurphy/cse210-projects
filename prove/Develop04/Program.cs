using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop04 World!");

        // Create userinput variable
        string userInput = "0";

        // Begin a loop that will host the menu that the user can see and select from.
        while (userInput != "5")
        {
            // Clears the console every time a call is made so that the console is clean.
            Console.Clear();

            // List the user's menu options.
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. Start Yoga Activity");
            Console.WriteLine("5. Quit");
            Console.Write("Select a choice from the menu: ");

            // Read the user input to the menu choices above.
            userInput = Console.ReadLine();

            // This will start if the user enters the number "1".
            if (userInput == "1")
            {
                // Using the BreathingActivity class we can construct both the BreathingActivity and Activity classes. 
                BreathingActivity breathingActivity = new BreathingActivity();

                // Now all we do is initiate the Run() method from the Breathing Class to begin the Breathing Activity.
                breathingActivity.Run();
            }

            // This will start if the user enters the number "2".
            else if (userInput == "2")
            {
                // Using the ReflectingActivity class we can construct both the ReflectingActivity and Activity classes.
                ReflectingActivity reflectingActivity = new ReflectingActivity();

                // Now all we do is initiate the Run() method from the Reflection class to begin the Reflecting Activity.
                reflectingActivity.Run();
            }

            // This will start if the user enters the number "3".
            else if (userInput == "3")
            {
                // Using the ListingActivity class we can construct both the ListingActivity and Activity classes.
                ListingActivity listingActivity = new ListingActivity();

                // Now all we do is initiate the Run() method from the Listing class to begin the Listing Activity.
                listingActivity.Run();
            }

            // This will start if the user enters the number "4'.
            else if (userInput == "4")
            {
                // Using the YogaActivity class we can construct both the YogaActivity and Activity clases.
                YogaActivity yogaActivity = new YogaActivity();

                // Now all we do is initiate the Run() method from the Yoga class to begin the Yoga Activity.
                yogaActivity.Run(); 
            }
        }
    }
}