using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Select a number");
        Random rnd = new Random();
        int number = rnd.Next(1, 101);
        int guess = 0;

        do
        {

            guess = int.Parse(Console.ReadLine());
            guess++;

            if (guess < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > number)
            {
                Console.WriteLine("Lower");
            }
        } while (guess != number);

        Console.WriteLine("You guessed it!");

    }
}