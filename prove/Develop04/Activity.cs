using System;
public class Activity
{
    // Attributes
    protected string _name;
    protected string _description;
    protected int _duration;

    //Constructors
    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // Methods
    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"This activity will help you {_description}");
        Console.WriteLine();
        Console.Write($"How long, in seconds, would you like for this session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Get ready...");
        
        
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of {_name}.");
        
    }

    public void ShowSpinner(int seconds)
    {
        
        List<string> spinner = new List<string>();
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        spinner.Add("|");
        spinner.Add("/");
        spinner.Add("-");
        spinner.Add("\\");
        spinner.Add("|");
        
        
        
        DateTime startTime = DateTime.Now;
        DateTime endTime =  startTime.AddSeconds(seconds);
        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = spinner[i];
            Console.Write(s);
            Thread.Sleep(300);
            Console.Write("\b \b");
            
            i++;

            if (i >= spinner.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 5; i > 0; i--)
        {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
        }
    }
    
}