using System;

namespace GoalTracker
{
    //SimpleGoal class is a subclass of Goal that represents a simple goal with only one step to completion
    class SimpleGoal : Goal
    {
        // Constructor for creating a new simple goal
        public SimpleGoal(string title, int value) : base(title, value)
        {
        }

        // Override the IsComplete method to check if the goal has been accomplished
        public override bool IsComplete()
        {
            return Progress == 1;
        }

        // Override the ProgressDescription property to describe the progress towards completing the goal
        public override string ProgressDescription
        {
            get { return IsComplete() ? "Complete!" : "Incomplete"; }
        }
    }
}
