using System;


class Program
{
    static void Main(string[] args)
    {

    string pick = "";
        do
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listening activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            pick = Console.ReadLine();
            if (pick == "1")
            {
                BreathingActivity bAct = new BreathingActivity();
                bAct.Run();
            }
            else if (pick == "2")
            {
                ReflectingActivity rAct = new ReflectingActivity();
                rAct.Run();
                
            }
            else if (pick == "3")
            {
                ListingActivity lAct = new ListingActivity();
                lAct.Run();
            }
            
        }
        while (pick != "4");
        Console.WriteLine("See you next time.");
    }
}