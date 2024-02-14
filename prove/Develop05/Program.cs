using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");

        // Added a menu to list only achieved goals.
        GoalManager goalManager = new GoalManager();

        goalManager.Start();

    }
}