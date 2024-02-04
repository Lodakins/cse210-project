

public class WritingAssignment: Assignment{


    private string _title;


    public WritingAssignment(string title, string sName, string topic) : base(sName,topic){
        _title = title;
    }


    public void SetTitle(string title){
        _title = title;
    }


    public string GetTitle(){
        return _title;
    }


    public string GetWritingInformation(){
        return $"{GetStudentName()} {GetTopic()} \n{GetTitle()}";
    }


}