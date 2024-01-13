using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
       
        DisplayWelcome();

        string name = PromptUserName();
        int number = PromptUserNumber();

        DisplayResult(name,number);
    }


    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    } 

    static string PromptUserName(){
        Console.WriteLine("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber(){
        Console.WriteLine("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    } 

    static void DisplayResult(string name, int number){
        Console.WriteLine($"{name}, the square of your number is {number *number}");
    }
}