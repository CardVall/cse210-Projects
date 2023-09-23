public class PromptGenerator
{
    public List<string> _prompts = new List<string>()
    {
        "What was I most grateful for today?", 
        "What was the first conversation I had today about?", 
        "What was the weather like today?", 
        "What is the most productive thing I did today?", 
        "What am I looking forward to most?"
    };


    public string GetRandomPrompt()
    {
        Random rand = new Random();

        int numb = rand.Next(_prompts.Count());
        string prompt = _prompts[numb];
        return prompt;
    }

    public void Display()
    {
        Console.WriteLine($"{GetRandomPrompt}");
    }

}