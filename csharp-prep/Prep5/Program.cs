using System;

class Program
{
    static void Main(string[] args)
    {
        {       //call function it displays a welcome message
            DisplayWelcome();

            //call function to prompt user for number and save the returned value
            string name = PromptUserName();

            //call function to prompt user for number and save the returned value
            int number = PromptUserNumber();

            //call function to display the result with user name and square number
            int result = SquareNumber(number);

            //call function to display the result with user name and square number
            DisplayResult(name, result);
        }

        static void DisplayWelcome()
        {
            //display welcome message
            Console.Write("Welcome to the Program!:");
        }


        static string PromptUserName()
        {
            //prompt user for name
            Console.Write("Please enter your name: ");
            //return user input as a string
            return Console.ReadLine();
        }

        static int PromptUserNumber()
        {
            //prompt user for number
            Console.Write("Please enter your favorite number: ");
            //return user input as an integer
            return int.Parse(Console.ReadLine());
        }
        static int SquareNumber(int number)
        {   //squares the number

            return number * number;
        }

        static void DisplayResult(string name, int result)
        {   //display the result with user name and square number
            Console.WriteLine("Hello, " + name + "1 Your favorite number squared is: " + result);
        }
    }
}