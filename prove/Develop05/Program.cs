using System;

// To exceed program requirements I added an individual class that manages a Level Bar for the user to see their progress up until level 20. 
// Their progress is saved according to the players scored and taken everytime the function is called (reducing the need to store extra variables).
// This extra fun gamification gives the user somthing to look forward too as far as progress and allows for extra motivation to make it to the next level.


class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Develop05 World!");

        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}