

public class SimpleGoal: Goal{

    private bool _isComplete;

    public SimpleGoal(string name, string description, int points):base(name,description,points){
        
    }

    public SimpleGoal(string name, string description, int points, bool IsComplete):base(name,description,points){
        _isComplete = IsComplete;
    }

    public void SetIsCompleted(bool completed){
        _isComplete = completed;
    }



    public override void RecordEvent(){
        SetIsCompleted(true);
        Console.WriteLine($"Congratulations! You have earned {GetPoint()} points!");

    }
    public override bool IsComplete(){
        return _isComplete;
    }

     public override string GetDetailsString(){
        string checkpoint = _isComplete ? "[X]" : "[ ]";
        return $"{checkpoint} {GetShortName()} ({GetDescription()})";
    }
    public override string GetStringRepresentation(){
        return $"SimpleGoal:{GetShortName()}:{GetDescription()}:{GetPoint()}:{IsComplete()}";
    }


}