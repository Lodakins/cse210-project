using System.Diagnostics;

namespace Activities
{


    public class Menu
    {


        private int _option;

        private string _filename;


        public void DisplayMenus()
        {

            Console.WriteLine("Menu Options:");

            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Load Activities Log");
            Console.WriteLine("\t5. Quit");

            Console.WriteLine("Select a choice from the menu:");
            int option = int.Parse(Console.ReadLine());
            SetOption(option);

        }


        public void SetFileName(string filename)
        {
            _filename = filename;
        }

        public string GetFileName()
        {
            return _filename;
        }

        public void SetOption(int option)
        {
            _option = option;
        }

        public int GetOption()
        {
            return _option;
        }

        public void LogActivity(Activity activity)
        {
            using (StreamWriter outputFile = new StreamWriter("activities.txt"))
            {
                // You can add text to the file with the WriteLine method
                outputFile.WriteLine($"{activity.GetName()};{activity.GetDuration()}");

            }
        }

        public void DisplayActivitiesLog()
        {

            List<Activity> activities = new List<Activity>();

            string[] lines = System.IO.File.ReadAllLines("activities.txt");

            foreach (string line in lines)
            {
                string[] parts = line.Split(";");
                Activity activity = new Activity(parts[0], "");
                activity.SetDuration(int.Parse(parts[1]));
                activities.Add(activity);
            }

            if(activities.Count == 0){
                Console.WriteLine("There has not been any activity");
            }else{
                foreach (Activity activity1 in activities)
                {
                    Console.WriteLine($"Activity Name - {activity1.GetName()}  Duration - {activity1.GetDuration()}");
                }
            }
            
        }

    }



}