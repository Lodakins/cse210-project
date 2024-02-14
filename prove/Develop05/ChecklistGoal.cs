

using System.IO.Pipes;

public class ChecklistGoal : Goal
{


    

    private int _amountCompleted = 0;

    private int _target;

    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus):base(name,description,points){
        _target = target;
        _bonus = bonus;
    }

    public ChecklistGoal(string name, string description, int points, int target, int bonus, int amountCompleted):base(name,description,points){
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public void SetAmountCompleted(int amountCompleted){
        _amountCompleted = amountCompleted;
    }

    public int GetAmountCompleted(){
        return _amountCompleted;
    }

    public void SetBonus(int bonus){
        _bonus = bonus;
    }

    public int GetBonus(){
        return _bonus;
    }  

    public void SetTarget(int target){
        _target = target;
    }

    public int GetTarget(){
        return _target;
    }

    public override void RecordEvent(){
        _amountCompleted+=1;

        if(_amountCompleted == _target){
            SetPoint(GetPoint() + _bonus);
        }
        Console.WriteLine($"Congratulations! You have earned {GetPoint()} points!");
    }
    public override bool IsComplete(){
        return false;
    }

    public override string GetDetailsString() {
         string checkpoint = _amountCompleted == _target ? "[X]" : "[ ]";
        return $"{checkpoint} {GetShortName()} ({GetDescription()}) --- Currently Completed: {_amountCompleted}/{_target}";
    }
    public override string GetStringRepresentation(){
        return $"ChecklistGoal:{GetShortName()}:{GetDescription()}:{GetPoint()}:{GetTarget()}:{GetBonus()}:{GetAmountCompleted()}";
    }
}