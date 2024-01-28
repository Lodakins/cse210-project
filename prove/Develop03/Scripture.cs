

class Scripture{


    private Reference _reference;
    private List<Word> _words;


    public Scripture(){

    }

    public Scripture(Reference reference, string text){
        reference = _reference;
        _words = SetWords(text);
    }

    public HideRandomWords(int numberToHide){

    }

    public string GetDisplayText(){

    }

    public bool IsCompletelyHidden(){


    }

    public List<Word> SetWords(string text){

        List<Word> words = new List<Word>();

        string[] texts = text.Split("-"); 
        foreach (string line in texts){
            Word word = new Word(line);
            words.Add(word);
        }
            
        return words;
    }


}