using System;

// Creates a class called Job we can use later
public class Job 
{
    // Creates variables that will be used to display a job and its details on the _jobs list in the main program
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Create a function called Display that displays the job details when called upon
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}