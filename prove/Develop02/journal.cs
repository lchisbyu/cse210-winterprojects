//This program will prompt the user if they want to type a new journal entry, 
//if yes, it will ask if they want to use today's date or insert a custom date. 
//Then it will prompt the user to type their journal entry and 
//it will append the entry in a file named "journal.txt" along with the date. 
//At the end, it will ask the user if they are finished with journal entry, 
//if yes, the program will end otherwise it will repeat the process again.

//This code is in progress 
/*
using System;

class Journal
{
    static void Main(string[] args)
    {
         bool finished = false;

         //flag to check if the user is finished with journal entry
         while (!finished)
         {
             Console.WriteLine("Do you want to type an entry?");
             string entryAnswer = Console.ReadLine();

             if (entryAnswer == "yes")
             {
                 Console.WriteLine("Do you want today's date?");
                 String dateAnswer = Console.ReadLine();

                 String date;
                 if (dateAnswer == "no")
                 {
                     Console.WriteLine("Insert date:");
                     date = Console.ReadLine();
                     //this gets the custom date from the user
                 }
                 else
                 {
                     date = DateTime.Now.ToString("MM/dd/yyyy");
                     //getting the current date
                 }
                 string entry = "Date:" = date = "\n";
                 //creating a new journal entry with the date

                 Console.WriteLine("Type your entry:");
                 string journal = Console.ReadLine();
                 entry += journal;

                 //Opening a new journal entry
                 using (StreamWriter sw = File.AppendText("journal.txt"))
                     [
                         sw.WriteLine(entry);
                 ]
                 Console.WriteLine("Journal entry saved");

                 Console.WriteLine("Are you finished?");
                 string finishedAnswer = Console.ReadLine();

                 if (finishedAnswer == "yes")
                 {
                     finished = true;
                 }
             }
         }
         else
         {
             finished = true;
         }

    }
}*/