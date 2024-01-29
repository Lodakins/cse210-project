

class Scripture{


    private Reference _reference;
    private List<Word> _words;


    public Scripture(){

    }

    public Scripture(Reference reference, string text){
        _reference = reference;
        _words = SetWords(text);
    }

    public void HideRandomWords(int numberToHide){
        _words[numberToHide].Hide();
    }

    public string GetDisplayText(){
        return $"{_reference.GetDisplayText()} {returnCompeleteWord()}";
    }

    public bool IsCompletelyHidden(){
        bool isHiddenCompletely = true;
        foreach(Word word in _words){
            isHiddenCompletely = isHiddenCompletely && word.IsHidden();
        }
        return isHiddenCompletely;
    }

    public List<Word> SetWords(string text){

        List<Word> words = new List<Word>();

        string[] texts = text.Split(" "); 
        foreach (string line in texts){
            Word word = new Word(line);
            words.Add(word);
        }
            
        return words;
    }

    public string returnCompeleteWord(){
        string text="";
        foreach(Word word in _words){
            text+=" "+word.GetDisplayText();
        }

        return text;
    }

    public int GetWordCount(){
        return _words.Count;
    }


}