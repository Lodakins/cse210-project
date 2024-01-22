namespace journal{


    class Journal{

        List<Entry> _entries = new List<Entry>();


        public void AddEntry(Entry entry){
            _entries.Add(entry);
        }

        public void DisplayAll(){
            foreach(Entry entry in _entries){
                entry.Display();
            }
        }


        public void SaveToFile(string filename){
           
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach(Entry entry in _entries){
                    // You can add text to the file with the WriteLine method
                    outputFile.WriteLine($"{entry._date}-{entry._prompText}-{entry._entryText}");
                }
            }
            
            
        }


        public void LoadFromFile(string filename){

            string[] lines = System.IO.File.ReadAllLines(filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("-");
                Entry entry = new Entry();
                entry._date= parts[0];
                entry._prompText = parts[1];
                entry._entryText=parts[2];

                AddEntry(entry);
            }
        }

    }


}