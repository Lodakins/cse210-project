using System;
using Activities;

class Program
{
    static void Main(string[] args)
    {
        ///  EXTRA FEATURE
        ///  A LOG OF THE ACITIVITIES UNDERTAKE WHEN THE PROGRAM IS RUNNING IS SAVED
        ///  AND USER CAN PICK AN OPTION TO DISPLAY THE LOG


        Menu menu = new Menu();
        menu.DisplayMenus();
        int option = menu.GetOption();

      
        while (option != 5)
        {
            
             
            if (option == 1)
            {
                BreathingAcitivity breathingAcitivity = new BreathingAcitivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
                breathingAcitivity.DisplayStartingMessage();
                Console.WriteLine("");
                Console.WriteLine("How long, in seconds, would you like for the session?");
                int seconds = int.Parse(Console.ReadLine());
                breathingAcitivity.SetDuration(seconds);
                breathingAcitivity.Run();
                menu.LogActivity(breathingAcitivity);
            }
            else if (option == 2)
            {
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
                reflectingActivity.DisplayStartingMessage();
                Console.WriteLine("");
                Console.WriteLine("How long, in seconds, would you like for the session?");
                int seconds = int.Parse(Console.ReadLine());
                reflectingActivity.SetDuration(seconds);
                reflectingActivity.Run();
                menu.LogActivity(reflectingActivity);
            }else if (option == 3){
                ListingActivity listingActivity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
                listingActivity.DisplayStartingMessage();
                Console.WriteLine("");
                Console.WriteLine("How long, in seconds, would you like for the session?");
                int seconds = int.Parse(Console.ReadLine());
                listingActivity.SetDuration(seconds);
                listingActivity.Run();
                menu.LogActivity(listingActivity);
            }else if (option == 4){
                menu.DisplayActivitiesLog();
                Thread.Sleep(2000);
            }
            Console.Clear();
            menu.DisplayMenus();
            option = menu.GetOption();
        }

    }
}