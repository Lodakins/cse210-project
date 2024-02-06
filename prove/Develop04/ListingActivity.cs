using System.Runtime.InteropServices;

namespace Activities
{


    public class ListingActivity : Activity
    {

        private int _count;
        private List<string> _prompts = new List<string>();

        Random random = new Random();

        public ListingActivity(string name, string desc) : base(name, desc)
        {
            _prompts.Add("Who are people that you appreciate?");
            _prompts.Add("What are personal strengths of yours?");
            _prompts.Add("Who are people that you have helped this week?");
            _prompts.Add("When have you felt the Holy Ghost this month?");
            _prompts.Add("Who are some of your personal heroes?");

        }

        public void SetCount(int count)
        {
            _count = count;
        }

        public int GetCount()
        {
            return _count;
        }


        public void Run()
        {
            Console.WriteLine("Get Ready...");
            ShowSpinner(4);

            Console.WriteLine("");
            Console.WriteLine("List as many responses as you can to the following prompt:");

            DateTime startTime = DateTime.Now;
            DateTime futureTime = startTime.AddSeconds(GetDuration());

            Console.WriteLine($"--- {GetRandomPrompt()} ---");
            Console.Write("You may begin in: ");
            ShowCountDown(5);
            Console.WriteLine("");

            List<string> answers = new List<string>();

            while (startTime <= futureTime)
            {
                Console.Write($"> ");
                string answer = Console.ReadLine();
                answers.Add(answer);
                startTime = DateTime.Now;
            }

            Console.WriteLine($"You listed {answers.Count} items!");

            DisplayEndingMessage();
            ShowSpinner(3);


        }

        public string GetRandomPrompt()
        {
            int no = random.Next(0, _prompts.Count);
            return _prompts[no];
        }
        // public List<string> GetListFromUser()
        // {
        //     List<string> answers = new List<string>();
        //     return users;
        // }


    }

}