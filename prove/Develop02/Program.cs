using System;
using journal;

class Program
{

    Journal journal = new Journal();
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

        Program program = new Program();

        int decision =-1;

        Console.WriteLine("Welcome to the Journal Program");

        do{
            Console.WriteLine("Please select one of the following choices");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");                
            Console.WriteLine("5. Quit");

            Console.WriteLine("What would you like to do");
            decision = int.Parse(Console.ReadLine());

            if(decision == 1){

                program.WritePrompt();

            }else if (decision == 2){
                
                program.DisplayAll();

            }else if(decision == 3){

                program.LoadFile();

            }else if(decision == 4){

                program.SaveFile();

            }

        }while(decision !=5);


       
    }

     public void WritePrompt(){
        
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        PromptGenerator promptGenerator = new PromptGenerator();
        string prompt = promptGenerator.GetRandomInput();

        Console.WriteLine(prompt);
        string input = Console.ReadLine();

        Entry entry = new Entry();
        entry._date = dateText;
        entry._prompText= prompt;
        entry._entryText = input;

        journal.AddEntry(entry);
            
    }


    public void DisplayAll(){
        journal.DisplayAll();
    }

    public void LoadFile(){
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        journal.LoadFromFile(filename);
    }

    public void SaveFile(){
        Console.WriteLine("What is the filename?");
        string filename = Console.ReadLine();
        journal.SaveToFile(filename);
    }
}