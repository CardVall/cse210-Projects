using System;

class Program
{
    static void Main(string[] args)
    {
        
        Reference reference = new Reference("D&C",67,13,14);
        Scripture scripture = new Scripture(reference,"Ye are not able to abide the presence of God now, neither the ministering of angels wherefore, continue in patience until ye are perfected. Let not your minds turn back and when ye are worthy, in mine own due time, ye shall see and know that which was conferred upon you by the hands of my servant Joseph Smith, Jun. Amen.");



        string keepPlaying = "";
        while (true)
        {
            Console.Clear();
            Console.Write($"{reference.GetDisplayText()} ");
            Console.WriteLine($"{scripture.GetDisplayText()}");
            Console.WriteLine("Press enter to continue of type 'quit' to finish: "); 
            keepPlaying = Console.ReadLine();
            if (scripture.IsCompletelyHidden() || keepPlaying == "quit")
            {
                break;
            }
            scripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.Write($"{reference.GetDisplayText()} ");
        Console.WriteLine($"{scripture.GetDisplayText()}");
        Console.WriteLine("Press enter to continue of type 'quit' to finish: ");
    }
}