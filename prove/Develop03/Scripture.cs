Using System; // used to store the reference and text of each scripture

namespace ScriptureMemory

{
    public class Scripture
    {
        public string Reference { get; set; }  //declares a public
        public string Text { get; set; }  //declares a public property named text of type string

        public Scripture(string reference, string text)  //declares a public constructor that takes two arguments, both of type string

        {
            Reference = reference;  // This line sets the value of the reference property to the value of the reference argument

            Text = text;  //sets the value of the reference property to the value of the reference argument

        }

    }
}