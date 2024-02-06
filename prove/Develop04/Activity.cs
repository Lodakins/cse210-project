namespace Activities
{

public class Activity{


    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string desc){
        _name = name;
        _description = desc;
    }


    public void SetName(string name){
        _name = name;
    }

    public string GetName(){
        return _name;
    }

     public void SetDescription(string desc){
        _description = desc;
    }

    public string GetDescription(){
        return _description;
    }

     public void SetDuration(int dur){
        _duration = dur;
    }

    public int GetDuration(){
        return _duration;
    }

    public void DisplayStartingMessage(){
        Console.WriteLine($"Welcome to the {_name} Activity \n\n{_description}");
    }
    public void DisplayEndingMessage(){
        Console.WriteLine("");
        Console.WriteLine("Well done!!");
        ShowSpinner(2);
        Console.WriteLine($"You have compeleted another {GetDuration()} seconds of the {GetName()} activity");
        ShowSpinner(2);
    }
    public void ShowSpinner(int seconds){

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);


        List<string> animationString = new List<string>();

        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        int i=0;
        while(startTime <= futureTime){
            
                Console.Write(animationString[i]);
                Thread.Sleep(1000);
                Console.Write("\b \b");

                i++;

            if(i >= animationString.Count){
                i=0;
            }
            startTime = DateTime.Now;
        }

    }
    public void ShowCountDown(int seconds){

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(seconds);

        int counter= seconds;
        int max = counter;
        while(startTime <= futureTime){

                Console.Write($"{max}");
                Thread.Sleep(1000);
                Console.Write("\b \b");

                max--;

            if(max <=0){
                max = counter;
            }
            startTime = DateTime.Now;
        }

    }

    public int GetRandomInt(int max){
        Random  random = new Random();
         if(max == 1){
            max = 5;
         }
        return random.Next(1, max);
    }
}
    
}