using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        int number = -1;
        float sum = 0;
        int largestNumber = 0;
        int smallestNumber = 999999999;

        Console.WriteLine("");
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (number != 0)
        {
            Console.Write("Enter a Number: ");
            number = int.Parse(Console.ReadLine()); 

            if (number != 0)
            {
                numbers.Add(number);
                sum = sum + number;
                
                if (largestNumber < number)
                {
                    largestNumber = number;
                }
                
                if (number > 0 && number < smallestNumber)
                {
                    smallestNumber = number;
                }
            }
        }

        Console.WriteLine($"The sum is: {sum}");
        float listSize = numbers.Count;

        float average = sum / listSize;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largestNumber}");
        
        Console.WriteLine($"The smallest positve number is: {smallestNumber}");

        Console.WriteLine("The sorted lsit is: ");
        numbers.Sort();
        foreach (int g in numbers)
        {
            Console.WriteLine(g);
        }
    }
}