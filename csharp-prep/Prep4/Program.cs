using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();     

        int response = -1;

        while (response != 0)
        {
            Console.Write("Enter a number (type 0 when finished): ");

            response = int.Parse(Console.ReadLine());

            if (response != 0)
            {
                numbers.Add(response);
            }
        }    
        int sum = 0;

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        int max = numbers[0];

        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}