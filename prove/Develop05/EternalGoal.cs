using System;

namespace GoalTracker
{
    //EternalGoal class is a subclass of Goal that represents a goal that can be completed multiple times for points
    class EternalGoal : Goal
    {
        // private member variable to hold the point value for each completion of the goal
        private int pointValue;

        // constructor to initialize the EternalGoal object with a name and point value
        public EternalGoal(string name, int pointValue) : base(name, 0)
        {
            this.pointValue = pointValue;
        }

        // method to record progress towards the goal and add points to the user's score
        public override void RecordProgress()
        {
            // add the point value for completing the goal to the user's score
            Value += pointValue;

            // display a message to the user indicating they have made progress towards the goal and how many points they earned
            Console.WriteLine($"Made progress towards {Title} and earned {pointValue} points!");
        }

        // method to get the string representation of the goal object
        public override string ToString()
        {
            // return a string that includes the goal name and the point value for each completion of the goal
            return $"{Title} ({pointValue} points per completion)";
        }
        public override string GetProgressDescription()
        {
            return IsComplete() ? "Complete!" : "Incomplete";
        }
    }
}
