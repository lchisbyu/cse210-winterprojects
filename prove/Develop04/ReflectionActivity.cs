using System;

namespace ActivityProgram
{
    class ReflectionActivity
    {
        public void StartActivity()
        {
            Console.WriteLine("Reflection activity started. Please answer the following questions:");
            Console.WriteLine("What did you do well today?");
            string positive = Console.ReadLine();
            Console.WriteLine("What could you improve upon tomorrow?");
            string negative = Console.ReadLine();

            Console.WriteLine("Thank you for your reflection.");
        }
    }
}