using System;

class Program
{

    static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._company = "WorldTech";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2014;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "HighTech";
        job2._jobTitle = "Data Analyst";
        job2._startYear = 2012;
        job2._endYear = 2022;

        Resume resume = new Resume();
        resume._name = "Bob Billings";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.DisplayResumeDetails();

        //   the Main method is defined in the Program class and creates instances
        // of Class1 and Class2 and calls methods on them.
        // It is important to note that the Main method must be in the same namespace as the class
        // where the method is defined. 
        // If the class is in a different namespace, 
        // you need to use using to import the namespace in your main file.
        // You can also put the main method in a separate file, in this case, 
        // you need to ensure that the class containing the main method is public 
        // and must be in the same namespace as the main method.

        //Class1 class1 = new Class1();
        //class1.Method1();
        //Class2 class2 = Class2();
        //class2.Method2()

        //Console.Readkey();

    }
}


// Job job = new Job();
//Resume resume 
//job.DisplayJob();