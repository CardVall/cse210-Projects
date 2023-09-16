using System;

class Program
{
    static void Main(string[] args)
    {
        // Console.Write("Please enter the magic number: ");
        // string magicNumber = Console.ReadLine();
        // int numMagic = int.Parse(magicNumber);

        // Console.Write("What is your guess: ");
        // string numberGuess = Console.ReadLine();
        // int numGuess = int.Parse(numberGuess);

        Random randomGenerator = new Random();
        int numMagic = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != numMagic)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > numMagic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < numMagic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.Write("You guessed it!");
            }
        }
    }
}