using System;

// Create a reusable class called Resume that we use in our main program
public class Resume
{
    // Create a string variable for us to enter the name of the person listing their Resume
    public string _name;

    // We are initializing our list into a blank new list before we ever call it.
    public List<Job> _jobs = new List<Job>();

    // This function displays the name of the resume user and then lists all their jobs received from the _jobs list.
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // This is where we go through each item in the _jobs list and then display it to the terminal
        foreach (Job item in _jobs) 
        {
            item.Display();
        }
    }
}