using System;

public class BreathingActivity : Activity
{
    //Attributes
    
    //Constructors
    public BreathingActivity() : base("Breathing Activity", "relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.", 0)
    {

    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(2);
        

        
        DateTime startTime = DateTime.Now;
        DateTime endTime =  startTime.AddSeconds(_duration);
        while(DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.Write($"Breath in... ");
            ShowCountDown(5);
            Console.WriteLine();
            
            Console.Write($"Breath out... ");
            ShowCountDown(5);
            Console.WriteLine();
            

        }
        
        DisplayEndingMessage();
        ShowSpinner(5);

    }
}