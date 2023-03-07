using System;

namespace ActivityProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Activity Program!");
            Console.WriteLine("Please select an activity:");
            Console.WriteLine("1. Breathing");
            Console.WriteLine("2. Reflection");
            Console.WriteLine("3. Listing");

            int activityChoice = int.Parse(Console.ReadLine());

            if (activityChoice == 1)
            {
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.StartActivity();
            }
            else if (activityChoice == 2)
            {
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.StartActivity();
            }
            else if (activityChoice == 3)
            {
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.StartActivity();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }

            Console.WriteLine("Thanks for using the Activity Program!");
            Console.ReadLine();
        }
    }
}