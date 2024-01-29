using System;

class Program
{
    static void Main(string[] args)
    {

        /// Extra features
        // After a user have finished all scriptures. There is an option to continue memorizing 
        // scripture where by a new random scripture is display for the user.

        Console.WriteLine("Hello Develop03 World!");


         Random randomgenerator = new Random();

         List<Scripture> _scriptures = new List<Scripture>();

         Reference reference = new Reference("John",3,16);
         string text="For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
         Scripture scripture = new Scripture(reference,text);

        Reference reference1 = new Reference("John",1,1);
         string text1="In the beginning was the Word, and the Word was with God, and the Word was God";
         Scripture scripture2 = new Scripture(reference1,text1);

         Reference reference2 = new Reference("Genesis",1,1,2);
         string text2="In the beginning God created the heaven and the earth. And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters.";
         Scripture scripture3 = new Scripture(reference2,text2);

         Reference reference3 = new Reference("Revelations",12,11);
         string text3="And they overcame him by the blood of the Lamb, and by the word of their testimony; and they loved not their lives unto the death.";
         Scripture scripture4 = new Scripture(reference3,text3);

         Reference reference4 = new Reference("Provers",3,5,6);
         string text4="Trust in the LORD with all thine heart; And lean not unto thine own understanding. In all thy ways acknowledge him, And he shall direct thy paths.";
         Scripture scripture5 = new Scripture(reference4,text4);


        _scriptures.Add(scripture);
        _scriptures.Add(scripture2);
        _scriptures.Add(scripture3);
        _scriptures.Add(scripture4);
        _scriptures.Add(scripture5);

        
        int scripno = randomgenerator.Next(0,_scriptures.Count);
        Scripture scrip = _scriptures[scripno];

        Console.WriteLine(scrip.GetDisplayText());
        Console.WriteLine();

         string cont="";

         

        do{
            Console.WriteLine("Press enter to continue or type quit to finish");
            cont = Console.ReadLine();

            if(cont != "quit"){
                if(scrip.IsCompletelyHidden()){
                Console.WriteLine("Do you want to continue memorizing the scripture? Enter Yes or No");
                string answer = Console.ReadLine();
                    if(answer == "Yes"){
                        scripno = randomgenerator.Next(0,_scriptures.Count);
                        scrip = _scriptures[scripno];

                        Console.Clear();
                        Console.WriteLine(scrip.GetDisplayText());
                        Console.WriteLine();
                        
                    }else{
                        cont="quit";
                    }
                
                }else{
                    int no = randomgenerator.Next(0,scrip.GetWordCount());
                    scrip.HideRandomWords(no);

                    Console.Clear();
                    Console.WriteLine(scrip.GetDisplayText());
                    Console.WriteLine();

                }
            }
            
        }while(cont!="quit");
       
    }
}

