using System;

namespace GoalTracker
{
    // Goal class is an abstract class that will be inherited by other classes such as SimpleGoal and EternalGoal
    abstract class Goal
    {
        //Properties of Goal class
        public string Title { get; protected set; } // The title of the goal
        public int Value { get; protected set; } // The value of the goal (how many points it is worth)
        public int Progress { get; protected set; } // The current progress towards completing the goal
        public abstract string GetProgressDescription(); // A description of the progress towards completing the goal

        // Constructor for creating a new goal
        public Goal(string title, int value)
        {
            Title = title;
            Value = value;
            Progress = 0;
        }

        // Method for recording progress towards the goal
        public virtual void RecordProgress()
        {
            Progress++;
            Console.WriteLine("Progress towards {0}: {1}", Title, GetProgressDescription());
        }

        // Method for checking if the goal is complete
        public virtual bool IsComplete()
        {
            return false;
        }
    }
}
