public class ScriptureRepository
{
    private Scripture[] _scriptures;

    public ScriptureRepository()
    {
        _scriptures = new Scripture[]
        {
            new Scripture("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture("Matthew", 5, 3, 12, "Blessed are the poor in spirit, for theirs is the kingdom of heaven."),
            new Scripture("Ephesians 2:8-9", "For it is by grace you have been saved, through faith--and this is not from yourselves, it is the gift of God--not by works, so that no one can boast."),
            new Scripture("And it came to pass that I beheld a tree, whose fruit was desirable to make one happy. And it came to pass that I did go forth and partake of the fruit thereof; and I beheld that it was most sweet, above all that I ever before tasted. Yea, and I beheld that the fruit thereof was white, to exceed all the whiteness that I had ever seen. And as I partook of the fruit thereof it filled my soul with exceedingly great joy; wherefore, I began to be desirous that my family should partake of it also; for I knew that it was desirable above all other fruit.1 Nephi 8:10-12 )
        }
    }

    public Scripture GetScripture(int index)
    {
        return _scriptures[index];
    }

    public int GetScriptureCount()
    {
        return _scriptures.Length;
    }
}