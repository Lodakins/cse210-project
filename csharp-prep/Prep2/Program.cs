using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        
        Console.WriteLine("Enter your grade percentage: ");
        int grade = int.Parse(Console.ReadLine());

        // if(grade >= 90){
        //     Console.WriteLine("A");
        // }else if(grade >= 80){
        //     Console.WriteLine("B");
        // }else if(grade >= 70){
        //     Console.WriteLine("C");
        // }else if(grade >= 60){
        //     Console.WriteLine("D");
        // }else{
        //     Console.WriteLine("F");
        // }
       
        string letter="";

        if(grade >= 90){
            letter= "A";
        }else if(grade >= 80){
            letter= "B";
        }else if(grade >= 70){
            letter= "C";
        }else if(grade >= 60){
            letter= "D";
        }else{
            letter= "F";
        }

        Console.WriteLine(letter);

         if(grade >= 70){
            Console.WriteLine("Congratulations!!!, you passed the course.");
        }else{
            Console.WriteLine("You failed the course. Try Again.");
        }


    }
}