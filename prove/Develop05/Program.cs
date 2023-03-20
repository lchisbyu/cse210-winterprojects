using System;


namespace GoalTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates instances of SimpleGoal and EternalGoal
            Goal simpleGoal = new SimpleGoal("Complete a 5k", 10);
            Goal eternalGoal = new EternalGoal("Meditate", 2);

            //Prints out the goals and their progress
            Console.WriteLine("My Goals:");
            Console.WriteLine(simpleGoal.ToString());
            Console.WriteLine(eternalGoal.ToString());

            //record progress for the goals
            simpleGoal.RecordProgress();
            simpleGoal.RecordProgress();
            eternalGoal.RecordProgress();
        }
    }
}