using System;


class Program
{
    static void Main(string[] args)
    {
        
        int userChoice = 0;
        PromptGenerator aprompt = new PromptGenerator();
        aprompt.GetRandomPrompt();

        Journal theJournal = new Journal();
        theJournal.DisplayAll();

        

        while (userChoice != 5)
        {
            DisplayMenu();
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                Entry newEntry = new Entry();
                newEntry._promptText = aprompt.GetRandomPrompt();
                Console.WriteLine($"{newEntry._promptText}");
                string userEntry = Console.ReadLine();
                newEntry._entryText = userEntry;
                theJournal.AddEntry(newEntry);
                
            }

            else if (userChoice == 2)
            {
                theJournal.DisplayAll();
            }

            else if (userChoice == 3)
            {
                Console.WriteLine("What is the file name?");
                string file = Console.ReadLine();
                string[] lines = theJournal.LoadFromFile(file);
                foreach (string line in lines)
                {
                    string[] parts = line.Split("-");
                    Entry newEntry = new Entry();
                    newEntry._date = parts[0];
                    newEntry._promptText = parts[1];
                    newEntry._entryText = parts[2];
                    theJournal.AddEntry(newEntry);
                }
            }

            else if (userChoice == 4)
            {
                Console.WriteLine("What is the file name?");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);

            }

            else if (userChoice == 5)
            {
            System.Environment.Exit(1);
            }

            else
            {
                Console.WriteLine("Invalid input! Please enter a number from 1 to 5.");
            }
        }

    }

    static void DisplayMenu ()
    {
        Console.Write(@"Please select one of the following choices:
1. Write
2. Display
3. Load
4. Save
5. Quit
What would you like to do? ");
    }

}