using System;


namespace journal{

    class PromptGenerator{

        public List<string>  _prompts = new List<string>();
        Random randomgenerator = new Random();

        public PromptGenerator(){
            this._prompts.Add("Who was the most interesting person I interacted with today?");
            this._prompts.Add("What was the best part of my day?");
            this._prompts.Add("How did I see the hand of the Lord in my life today?");
            this._prompts.Add("What was the strongest emotion I felt today?");
            this._prompts.Add("If I had one thing I could do over today, what would it be?");

        }

        public string GetRandomInput(){

            int no = randomgenerator.Next(1,_prompts.Count);

            return _prompts[no];
        
        }

    }


}