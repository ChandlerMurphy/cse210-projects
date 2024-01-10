using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep2 World!");

        // creates a blank line to start the program
        Console.WriteLine("");

        // Ask the user for their grade percentage and save as an Int variable
        Console.Write("What is your grade percentage as a whole number? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        // Give blank holders for variables to change
        string letter = "";
        string sign = "";

        // Now give if and else if statements to determine the letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }  
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        } 
        else
        {
            letter = "F";
        }

        // Now make a variable to help us determine the right operator for each grade
        int lastDigit = grade % 10;

        // Give if and else if statments to determine the right operator for each grade including A+
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // This final piece helps decide a few extra exceptions to the operators of specific grades. 
        if (grade >= 93)
        {
            sign = "";
        }
        if (letter == "F")
        {
            sign = "";
        }

        // Display to the user what their grade is
        Console.WriteLine($"Your letter grade is: {letter}{sign}");

        // Determine if they pass or not based on their grade
        if (grade >= 70)
        {
            Console.WriteLine("You Passed passed the class! Congratulations!");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Better luck next time!");
        }

        // creates a blank line to end the program
        Console.WriteLine("");
    }
}