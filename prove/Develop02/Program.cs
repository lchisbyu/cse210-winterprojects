using System;
using System.IO;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        {
            Prompt generator = new Prompt();
            Journal theJournal = new Journal();

            bool finished = false;

            while (!finished)
            {
                Console.WriteLine("1. Write a new Entry?");
                Console.WriteLine("2. Display the Journal?");
                Console.WriteLine("3. Save the Journal?");
                Console.WriteLine("4. Load the journal from a file?");
                Console.WriteLine("5. Exit?");
                Console.WriteLine("Enter a number to select");

                string UserInput = Console.ReadLine();


                if (UserInput == "1")
                {
                    //headline
                    Console.WriteLine("Write New Entry Here!.");

                    //get entry index
                    Console.WriteLine("What entry number is this?");
                    string entryNumber = Console.ReadLine();

                    //get a new prompt and display it
                    string prompt = generator.GetRandomPrompt();
                    Console.WriteLine(prompt);

                    //get the user's response text
                    string response = Console.ReadLine();

                    //add a title to the entry
                    Console.WriteLine("Add a title.");
                    string titleResponse = Console.ReadLine();

                    // get the current date and save it as a string
                    string date = DateTime.Now.ToString("yyy-MM-dd");

                    //create the entry object
                    Entry theEntry = new Entry();
                    theEntry._index = entryNumber;
                    theEntry._date = date;
                    theEntry._entry = response;
                    theEntry._prompt = prompt;
                    theEntry._title = titleResponse;

                    //add it to the journal
                    theJournal.AddEntry(theEntry);
                }

                else if (UserInput == "2")  //Use the Use the DisplayJournal method from the JournalEntry class
                {
                    theJournal.DisplayJournal();
                }

                else if (UserInput == "3")
                {
                    Console.Write("What is the name of the file? ");
                    string file = Console.ReadLine();

                    theJournal.SaveJournalToFile(file);
                    Console.WriteLine($"Journal entries save to {file}.");
                }

                else if (UserInput == "4")
                {
                    Console.Write("What is the name of the File? ");
                    string file = Console.ReadLine();

                    theJournal.LoadJournalFromFile(file);
                    Console.WriteLine($"Journal entries loaded from {file}");
                }

                else if (UserInput == "5")
                {
                    finished = true;
                }

                else
                {
                    Console.WriteLine("Invalid choice, try again");
                }
            }
        }
    }
}