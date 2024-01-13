using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        Random randomgenerator = new Random();

        

        bool correct = false;
        int noOfGuess=0;
        bool retry = false;

        // Console.WriteLine("What is your magic number? ");
        // int magicnumber = int.Parse(Console.ReadLine());

        int magicnumber = randomgenerator.Next(1,101);
        Console.WriteLine(magicnumber);
        

        do{
            Console.WriteLine("What is your guess? ");
            int guess = int.Parse(Console.ReadLine());

            noOfGuess++;
            if(guess > magicnumber){
                Console.WriteLine("Higher");
            }else if( guess < magicnumber){
                Console.WriteLine("Lower");
            }else{
                Console.WriteLine($"Congratulations!!!. You guessed it. You guess {noOfGuess} times. ");
                correct=true;
                Console.WriteLine("Do you want to retry? Y or N");
                string response = Console.ReadLine();
                if(response =="Y"){
                    retry= true;
                    noOfGuess=0;
                    magicnumber = randomgenerator.Next(1,101);
                }
            }

        }while(!correct || !!retry);

        

    }
}