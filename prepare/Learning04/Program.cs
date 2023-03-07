using System;

class Program

{
    static void Main(string[] args)
    {
        // Test Assignment class
        var assignment = new Assignment("John Doe", "History");
        Console.WriteLine(assignment.GetSummary()); // Output: John Doe - History

        // Test MathAssignment class
        var mathAssignment = new MathAssignment("Jane Smith", "Fractions", "7.3", "3-10, 20-21");
        Console.WriteLine(mathAssignment.GetSummary()); // Output: Jane Smith - Fractions
        Console.WriteLine(mathAssignment.GetHomeworkList()); // Output: Section 7.3, problems 3-10, 20-21

        // Test WritingAssignment class
        var writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writingAssignment.GetSummary()); // Output: Mary Waters - European History
        Console.WriteLine(writingAssignment.GetWritingInformation()); // Output: The Causes of World War II by Mary Waters
    }
}