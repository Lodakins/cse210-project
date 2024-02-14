

public abstract class Goal{


    private string _shortName;

    private string _description;

    private int _points;


    public Goal(string name, string description, int points){
        _shortName = name;
        _description = description;
        _points = points;
    }


    public void SetShortName(string shortName){
        _shortName = shortName;
    }

    public string GetShortName(){
        return _shortName;
    }

    public void SetDescription(string desc){
        _description = desc;
    }

    public string GetDescription(){
        return _description;
    }

    public void SetPoint(int point){
        _points = point;
    }

    public int GetPoint(){
        return _points;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    
    public virtual string GetDetailsString(){
        return $"[ ] {_shortName} ({_description})";
    }
    public abstract string GetStringRepresentation();
}