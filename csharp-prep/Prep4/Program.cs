using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //This is where you initialize an empty list to store the numbers
        List<int> numbers = new List<int>();


        int input = -1;

        //This is the While loop that continuously will prompt the user for input until they enter 0
        while (input != 0)
        {
            Console.Write("Enter a number then press 0 to quit: ");
            input = int.Parse(Console.ReadLine());

            if (input != 0)
            {
                numbers.Add(input);
            }


        }
        // while (input != 0) ;

        // This Initializes a variable to store the sum of the numbers
        int sum = 0;

        // This is sum up of all the numbers in the list
        for (int i = 0; i < numbers.Count; i++)

        {
            sum += numbers[i];
        }


        //This calculates the average of the numbers in the list
        double average = (double)sum / numbers.Count;

        //This find the maximum number in the list
        int max = numbers.Max();

        //This finds the minimum positive number in the list
        int minPositive = numbers.Where(n => n > 0).Min();

        //This sorts the numbers in the list
        numbers.Sort();

        //These next code lines print the results to the console
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average:" + average);
        Console.WriteLine("Max: " + max);
        Console.WriteLine("Min Positive: " + minPositive);
        Console.WriteLine("Sorted List:" + string.Join(",", numbers));

    }
}