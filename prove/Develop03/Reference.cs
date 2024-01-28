


public class Reference{

    private string _book;
    private int _chapter;
    private int _start_verse;
    private int _end_verse;


    public Reference(){

    }

    public Reference(sting book, int chapter, int start_verse){
        _book = book;
        _chapter = chapter;
        _start_verse = start_verse;
    }

    public Reference(sting book, int chapter, int start_verse, int end_verse){
        _book = book;
        _chapter = chapter;
        _start_verse = start_verse;
        _end_verse = end_verse;
    }

    public string GetDisplayText(){
        return $"{}:{}";
    }

}