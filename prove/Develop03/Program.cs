//This file is the entry point of the program.  It creates an instance of the Scripture management class and adds a sample scripture to it, it calls the method
using System;

class Program
{
    static void Main(string[] args)                  //method declaration, declared as static or void, point of entry, static keyword = method can be called without creating an instance of the class that contains it  void = keyword indicates that the method doesn't return a value.
                                                     //The Main takes an argument of the type "string{}' named args, which represents an array of strings. The args parameter is used to pass command line arguments to the application.
    {
        string scripture = "Place scripture here";  // This code creates a string variable in C# named scripture and it initializes it with a string literal value "Place scripture here.

        string[]                                    //declares a variable in C# of type string[] which is an array of strings
            words = scripture.Split(' ');           //The split method requires a character as the separator, you will get an error if you pass it empty to an argument

        int index = 0;                              //declares an integer variable, int = data type, the variable index is declared and assigned to the value 0, index variable can be used to store and manipulate integer values in the code, 

        while (index < words.Length)                //While loop posts each word  in array
        {
            Console.Write(words[index] + "");       //method used to print the word stored at the current index in the words array
            index++;                                //variable is incremented by 1 after each iteration of the loop.  Allows loop to move to the next word in the words array until all the words have been processed
        }

        Console.WriteLine();                        //The Console class provides various methods to interact with the console, and moves cursor to next line
        Console.ReadKey();                          // method of the console class reads the next character or function key pressed by the user
    }
}
