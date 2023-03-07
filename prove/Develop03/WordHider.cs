public class WordHider
{
    private string[] _words;
    private HashSet<int> _hiddenIndices;

    public WordHider(string text)
    {
        _words = text.Split(' ');
        _hiddenIndices = new HashSet<int>();
    }

    public void HideNextWord()
    {
        int index;
        do
        {
            index = new Random().Next(_words.Length);
        } while (_hiddenIndices.Contains(index));

        _hiddenIndices.Add(index);
        _words[index] = new string('_', _words[index].Length);
    }

    public bool AllWordsHidden()
    {
        return _hiddenIndices.Count == _words.Length;
    }

    public override string ToString()
    {
        return string.Join(" ", _words);
    }
}