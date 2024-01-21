using System;


namespace journal{

    class PromptGenerator{

        public List<string>  _prompts = new List<string>();
         Random randomgenerator = new Random();


        public string GetRandomInput(){

            int no = randomgenerator.Next(1,_prompts.Count);

            return _prompts[no];
        
        }

    }


}