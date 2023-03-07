using System;

namespace ActivityProgram
{
    class ListingActivity
    {
        public void StartActivity()
        {
            Console.WriteLine("Listing activity started. Please list five things:");
            string[] listItems = new string[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Item " + (i + 1) + ":");
                listItems[i] = Console.ReadLine();
            }

            Console.WriteLine("Your list:");

            foreach (string item in listItems)
            {
                Console.WriteLine("- " + item);
            }

            Console.WriteLine("Listing activity completed.");
        }
    }
}