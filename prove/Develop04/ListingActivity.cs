using System;


public class ListingActivity : Activity
{
    //Attributes
    private int _count;
    private List<string> _prompts;

    //Constructors
    public ListingActivity() : base("Listing Activity", "reflect on the good things in your life by having you list as many things as you can in a certain area.", 0)
    {
        List<string>_prompts = new List<string>(){
            ""
        };
    }

    //Methods
    public void Run()
    {
        DisplayStartingMessage();
        ShowSpinner(5);

    }

    public void GetRandomPrompt()
    {

    }
    
    public string GetListFromUser()
    {
        return "";
    }
    
}