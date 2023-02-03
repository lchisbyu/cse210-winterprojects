using System;

public class Reference
{
    public string Book { get; set; }       // declares a public property
    public int Chapter { get; set; }       // declares a public property 

    public int Verse { get; set; }          // declares a public property 

    public Reference(string book, int chapter, int verse)  //declares a property named verse 
    {
        Book = book;                    //sets the value of the book property to the value of the book argument
        Chapter = chapter;              //sets the value of the chapter property to the value of the chapter argument
        Verse = verse;                  //sets the value of the verse property to  the value of the verse argument 
    }
}