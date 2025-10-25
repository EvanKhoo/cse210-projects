using System;

class Word
{
    private List<string> _words;
    private HashSet<int> _hiddenIndices;
    private Random _rand;

    public Word(string text)
    {
        _words = new List<string>(text.Split(' ', StringSplitOptions.RemoveEmptyEntries));
        _hiddenIndices = new HashSet<int>();
        _rand = new Random();
    }

    public void HideRandomWord()
    {
        // Find indices of words that are not hidden yet
        var available = Enumerable.Range(0, _words.Count)
            .Where(i => !_hiddenIndices.Contains(i))
            .ToList();

        if (available.Count == 0)
            return;

        int index = available[_rand.Next(available.Count)];
        string word = _words[index];
        _words[index] = new string('_', word.Length);
        _hiddenIndices.Add(index);
    }

    public bool AllHidden()
    {
        return _hiddenIndices.Count == _words.Count;
    }

    public string GetText()
    {
        return string.Join(" ", _words);
    }
}