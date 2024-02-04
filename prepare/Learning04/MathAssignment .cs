

public class MathAssignment : Assignment {

    private string _textbookSection;

    private string _problems;


    public MathAssignment(string textbookSection, string problems, string sName, string topic) : base(sName,topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }



    public string GetHomeWorkList(){
        return $"{_textbookSection} {_problems}";
    }


}