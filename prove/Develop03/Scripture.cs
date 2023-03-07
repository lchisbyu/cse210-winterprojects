public class Scripture
{
    public string Reference { get; }
    public string Text { get; }

    public Scripture(string reference, string text)
    {
        Reference = reference;
        Text = text;
    }

    public Scripture(string book, int chapter, int verseStart, int? verseEnd = null)
    {
        if (verseEnd == null)
            Reference = $"{book} {chapter}:{verseStart}";
        else if (verseStart == verseEnd)
            Reference = $"{book} {chapter}:{verseStart}";
        else
            Reference = $"{book} {chapter}:{verseStart}-{verseEnd}";

        Text = ""; // initialize empty text
    }

    public override string ToString()
    {
        return $"{Reference}\n{Text}";
    }
}