using System;



public class ListingActivity : Activity
{
    //Attributes
    private int _count;
    private List<string> _prompts;
    private Random random = new Random();

    //Constructors
    public ListingActivity() : base("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        _prompts = new List<string>(){
            "What are your greatest strenghts?", "Who has are your biggest supporters?", "When have you felt the spirit this week", "List some of the things you feel most blessed for this week?", "What good deeds have you done this week?"
        };
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);

        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetRandomPrompt();
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();
       
        DateTime startTime = DateTime.Now;
        DateTime endTime =  startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            Console.Write(">");
            Console.ReadLine();
            _count++;
        }
        GetListFromUser();
        
        DisplayEndingMessage();
        ShowSpinner(5);
    }

    public void GetRandomPrompt()
    {
        int index = random.Next(_prompts.Count);
        string randPrompt = _prompts[index];
        Console.WriteLine($"--- {randPrompt} ---");
    }
    
    public string GetListFromUser()
    {
        string result = $"You listed {_count} items!";
        Console.WriteLine(result);
        return result;
    }
}