

class Program
{
    static void Main(string[] args)
    {
        ScriptureRepository repository = new ScriptureRepository();
        int scriptureIndex = 0;
        bool quit = false;

        while (!quit)
        {
            Console.Clear();

            Scripture scripture = repository.GetScripture(scriptureIndex);
            Console.WriteLine(scripture);

            WordHider hider = new WordHider(scripture.Text);
            while (!hider.AllWordsHidden())
            {
                Console.Write("\nPress Enter to continue or type \"quit\" to exit: ");
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                {
                    quit = true;
                    break;
                }

                hider.HideNextWord();
                Console.Clear();
                Console.WriteLine(scripture.Reference);
                Console.WriteLine(hider);
            }

            if (!quit)
            {
                Console.WriteLine("\nCongratulations, you have memorized the scripture!");
                Console.Write("\nPress Enter to continue or type \"quit\" to exit: ");
                string input = Console.ReadLine().ToLower();

                if (input == "quit")
                    quit = true;
                else
                    scriptureIndex = (scriptureIndex + 1) % repository.GetScriptureCount();
            }
        }
    }
}
