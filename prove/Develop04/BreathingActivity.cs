namespace Activities
{

public class BreathingAcitivity : Activity{


    public BreathingAcitivity(string name, string desc): base(name,desc){
        
    }

    public void Run(){

        Console.WriteLine("Get Ready ....");

        ShowSpinner(4);

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        while(startTime <=  futureTime){
            DisplayBreathingSteps();

            startTime = DateTime.Now;
        }

        DisplayEndingMessage();
        ShowSpinner(3);
    }



    public void DisplayBreathingSteps(){

        int breathIntSec = GetRandomInt(4); 
        int breathOutSec = GetRandomInt(6);

        DisplayCounter(breathIntSec,"Breath in");
        Console.WriteLine("");
        DisplayCounter(breathOutSec,"Breath out");    

        Console.WriteLine("");
        Console.WriteLine("");

    }

    private void DisplayCounter(int count,string name){
         Console.Write($"{name}......");
          for(int i = count; i > 0; i--){
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
    
}