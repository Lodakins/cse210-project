

public class Word{

    private string _text;
    private bool _isHidden = false;

    public Word(){

    }

    public Word(string text){
        _text =text;
        _isHidden = false;
    }


    public void Hide(){
        _isHidden= true;
    }
    
    public void Show(){
        _isHidden = false;
    } 

    public bool IsHidden(){
        return _isHidden;
    }

    public string GetDisplayText(){
        return _isHidden ? "____" : GetText();
    }

    public void SetText(string text){
        _text = text;
    }

    public string GetText(){
        return _text;
    }

}