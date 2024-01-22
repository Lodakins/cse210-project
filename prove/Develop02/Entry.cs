namespace journal{

    class Entry{

        public string _date;
        public string _prompText;
        
        public string _entryText;

        public void Display(){
            Console.WriteLine($"Date: {this._date} - Prompt: {this._prompText} \n{this._entryText} \n");
        }


    }


}