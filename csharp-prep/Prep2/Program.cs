using System;

namespace gradecalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ask user for their grade percentage
            Console.Write("Enter your grade percentage: ");
            int grade = int.Parse(Console.ReadLine());

            string letter = "";
            string sign = "";

            //Determine the letter grade

            if (grade >= 90)
            {
                letter = "A";
                Console.Write(letter);
            }
            else if (grade >= 80)
            {
                letter = "B";
                Console.Write(letter);
            }
            else if (grade >= 70)
            {
                letter = "C";
                Console.Write(letter);
            }
            else if (grade >= 60)
            {
                letter = "D";
                Console.Write(letter);
            }
            else if (grade >= 50)
            {
                letter = "F";
                Console.Write(letter);
            }

            //Did student pass the class
            if (grade >= 70)
            {
                Console.WriteLine("Congratulations, you passed the class");

            }
            else
            {
                Console.WriteLine("Try again!");
            }

            //Determine if the letter grade should have a + or - sign
            if (letter == "A" || letter == "A-" || letter == "F")
            {
                sign = "";
            }

            else if (grade % 10 >= 7)
            {
                sign = "+";
            }

            else if (grade % 10 < 3)
            {
                sign = "-";
            }

            else
            {
                sign = "";
            }

            Console.WriteLine("Your letter grade is: " + letter + sign);







        }
    }
}