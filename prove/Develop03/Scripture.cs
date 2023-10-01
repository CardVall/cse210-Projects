using System;
using System.Linq;



public class Scripture
{
    Reference reference = new Reference("D&C",67,13,14);

    private List<Word> _words = new List<Word>()
    {

    };
    

    public Scripture(Reference reference, string text)
    { 
        var splitText = text.Split(" ");
        foreach (string line in splitText)
        {
            Word lines = new Word(line);
            _words.Add(lines);     
        }
    }

    public void HideRandomWords(int wordsToHide)
    {
        Random random = new Random();

            for (int i = 0; i < wordsToHide; i++)
            {
                int ranIndex = random.Next(_words.Count);
                _words[ranIndex].Hide();
            }
    }

    public string GetDisplayText()
    {
        string scrText = "";

        foreach (Word word in _words)
        {  
           Console.Write($"{word.GetDisplayText()} ");
        }
        return scrText;
    }
    
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}