namespace Activities
{


public class ReflectingActivity: Activity{


    private List<string>  _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    Random random = new Random();

    public ReflectingActivity(string name, string desc) : base(name, desc)
    {

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

        _prompts.Add("Think of a time when you stood up for someone else");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
    }


    public void Run(){

        Console.WriteLine("Get Ready...");

        ShowSpinner(4);

        Console.WriteLine("Consider the following prompt");
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(GetDuration());

        DisplayPrompt();

        while(startTime <=  futureTime){
            DisplayQuestions();
            startTime = DateTime.Now;
        }

        DisplayEndingMessage();
        ShowSpinner(3);

    }
    public string GetRandomPrompt(){

        int no = random.Next(0, _prompts.Count);
        return _prompts[no];

    }
    public string GetRandomQuestion(){
        int no = random.Next(0, _questions.Count);
        return _questions[no];
    }
    public void DisplayPrompt(){
        Console.WriteLine($"-- {GetRandomPrompt()} --");
        Console.WriteLine("");

        Console.WriteLine("When you have something in mind. Press enter to continue.");
        string cont = Console.ReadLine();

        if(cont != "quit"){
            Console.WriteLine("Now ponder on each of the following questions as they relate to this experience");

            Console.Write("You may begin in: ");
            ShowCountDown(4);
            Console.WriteLine("");

        }
    }
    public void DisplayQuestions(){
        int counterSec = GetRandomInt(_questions.Count); 
        Console.Write($"> {GetRandomQuestion()}");
        ShowSpinner(counterSec);
        Console.WriteLine("");
    }


    


} 

}