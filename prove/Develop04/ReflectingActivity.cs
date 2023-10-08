using System;

public class ReflectingActivity : Activity
{
    //Attributes
    private string prompt;
    private string question;
    private Random random = new Random();

    //Constructors
    public ReflectingActivity() : base("Reflecting Activity", "reflect on times in your life when you have shown strength and resilience.", 0)
    {
        
        List<string>_prompts = new List<string>(){
            "Think of a time when you stood up for someone else", "Think of a time when you did something really difficult", "Think of a time when you helped someone in need", "Think of a time when you did something truly selfless"};

        int pIndex = random.Next(_prompts.Count);
        prompt = _prompts[pIndex];


        List<string>_questions = new List<string>(){
            "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?",
            "What did you learn about yourself from this experience", "What would you do differently", "Did you achieve the outcome you desired"};

        int qIndex = random.Next(_questions.Count);
        question = _questions[qIndex];
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);


        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Displayprompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");

        while (true)
        {
            if (Console.KeyAvailable && Console.ReadKey(true).Key == ConsoleKey.Enter)
            {
                break;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Now ponder on the each of the following questions as they relate to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine();

        
        DateTime startTime = DateTime.Now;
        DateTime endTime =  startTime.AddSeconds(_duration);

        while(DateTime.Now < endTime)
        {
            for (int i = 0; i < 5; i++)
            {
                DisplayQuestions();
                ShowSpinner(5);
            }
        }

        DisplayEndingMessage();
        ShowSpinner(5);

    }
    
    public string GetRandomPrompt()
    {   
        
        return prompt;
    }

    public string GetRandomQuestion()
    {
        return question;
    }

    public void Displayprompt()
    {
        string rPrompt = GetRandomPrompt();
        Console.WriteLine(rPrompt);
    }

    public void DisplayQuestions()
    {
        string rQestion = GetRandomQuestion();
        Console.WriteLine(rQestion);
    }
}