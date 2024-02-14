

public class GoalManager{


    private List<Goal> _goals = new List<Goal>();

    private List<Goal> _achievedgoals = new List<Goal>();

    private int _option;

    private int _goaloption;

    private int _score = 0;

    public void Start(){

        Console.WriteLine($"You have {_score} points");
        Console.WriteLine("");
        DisplayMenu();


        while(_option !=7){

            if(_option == 1){
                ListGoalNames();
                CreateGoal();
            }else if ( _option == 2){
                ListGoalDetails();
            }else if ( _option == 3){
                SaveGoals();
            }else if ( _option == 4){
                LoadGoals();
            }else if(_option ==5){
                RecordEvent();
            }else if(_option ==6){
                ListAchievedGoalDetails();
            }

            

            Console.WriteLine("");
            Console.WriteLine($"You have {_score} points");
            Console.WriteLine("");
            DisplayMenu();
        }

    }

    public void DisplayPlayerInfo(){


    }

    public void ListGoalDetails(){
        Console.WriteLine("The goals are: ");
        int no = 1;
        foreach( Goal  goal in _goals){
          if(!goal.IsComplete()){
                Console.WriteLine($"{no}. {goal.GetDetailsString()}");
                no++;
            }
        }

    }

    public void ListAchievedGoalDetails(){
        Console.WriteLine("The achieved goals are: ");
        int no = 1;
        foreach( Goal  goal in _goals){
            if(goal.IsComplete()){
                Console.WriteLine($"{no}. {goal.GetDetailsString()}");
                no++;
            }
            
        }

    }

    public void ListGoalNames(){
        Console.WriteLine("The type of Goals are:");

        Console.WriteLine("\t1. Simple Goal");
        Console.WriteLine("\t2. Eternal Goal");
        Console.WriteLine("\t3. Checklist Goal");

        Console.WriteLine(" ");
        Console.WriteLine("Which type of goal would you like to create?");

        int option = int.Parse(Console.ReadLine());
        SetGoalOption(option);

    }

    public void CreateGoal(){
        Goal goal = null;
        Console.WriteLine("What's the name of your goal?");
        string name = Console.ReadLine();
        Console.WriteLine("What's the short description of the goal?");
        string desc = Console.ReadLine();
        Console.WriteLine("What's the amount of points associate with this goal?");
        int points = int.Parse(Console.ReadLine());

        if(_goaloption == 1){
            goal = new SimpleGoal(name, desc, points);

        }else if (_goaloption == 2){
            goal = new EternalGoal(name,desc,points);

        }else if (_goaloption == 3){
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            int times = int.Parse(Console.ReadLine());

            Console.WriteLine("What's the bonus for accomplishing it that many times?");
            int bonus = int.Parse(Console.ReadLine());
            goal = new ChecklistGoal(name,desc,points,times,bonus);
        }




        _goals.Add(goal);


    }

    public void ListAllGoals(){
        Console.WriteLine("The goals are: ");
        int no = 1;
        foreach( Goal  goal in _goals){
            Console.WriteLine($"{no}. {goal.GetShortName()}");
            no++;
        }

    }

    public void RecordEvent(){
        ListAllGoals();
        Console.WriteLine("Which goal did you accomplish?");
        int record = int.Parse(Console.ReadLine());

        Goal goal = _goals[record-1];
        goal.RecordEvent();
        _score+=goal.GetPoint();

     
        
        Console.WriteLine($"You now have {_score} points.");

    }

    public void SaveGoals(){

        Console.WriteLine("What's the filename for the goal file?");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine($"Scores:{_score}");
            // You can add text to the file with the WriteLine method
            foreach(Goal goal in _goals){
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
            
        }
    }

    public void LoadGoals(){
         Console.WriteLine("What's the filename for the goal file?");
        string filename = Console.ReadLine();


        string[] lines = System.IO.File.ReadAllLines(filename);

        

        foreach (string line in lines)
        {
            Goal goal = null;
            string[] parts = line.Split(":");

            if(parts[0] == "Scores"){
                _score =int.Parse(parts[1]);
            }else if(parts[0] == "ChecklistGoal"){
                goal = new ChecklistGoal(parts[1],parts[2],int.Parse(parts[3]),int.Parse(parts[4]),int.Parse(parts[5]),int.Parse(parts[6]));
            }else if(parts[0] == "SimpleGoal"){
                goal = new SimpleGoal(parts[1],parts[2],int.Parse(parts[3]),bool.Parse(parts[4]));
            }else if(parts[0] == "EternalGoal"){
                goal = new EternalGoal(parts[1],parts[2],int.Parse(parts[3]));
            }

            if (goal != null){
                _goals.Add(goal);
            }
            
        }

    }

    private void DisplayMenu(){
        Console.WriteLine("Menu Options:");

        Console.WriteLine("\t1. Create New Goal");
        Console.WriteLine("\t2. List Goals");
        Console.WriteLine("\t3. Save Goals");
        Console.WriteLine("\t4. Load Goals");
        Console.WriteLine("\t5. Record Goals");
        Console.WriteLine("\t6. List Achieved Goals");
        Console.WriteLine("\t7. Quit");

        Console.WriteLine("Select a choice from the menu:");
        int option = int.Parse(Console.ReadLine());
        SetOption(option);
    }

     public void SetOption(int option)
        {
            _option = option;
        }

        public int GetOption()
        {
            return _option;
        }


     public void SetGoalOption(int option)
        {
            _goaloption = option;
        }

        public int GetGoalOption()
        {
            return _goaloption;
        }

}