using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");


        Assignment assignment = new Assignment("Lolade Akinrolabu","CSP102");
        Console.WriteLine(assignment.GetSummary());
    }

}