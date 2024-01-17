using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Learning02 World!");

        // Create first job listing information
        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2022;

        // Create second job listing information
        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._company = "Apple";
        job2._startYear = 2022;
        job2._endYear = 2023;

        // Using the Resume class we assign it to myResume and make a new object with those attributes and behaviors
        Resume myResume = new Resume();

        // Assign one of the internal attributes a name
        myResume._name = "Chandler Murphy";

        // Then add each job listing from above to the list in the myResume object
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Then call the display function in the myResume object to read off the list of jobs in its internal list to the terminal
        myResume.Display();
    }
}