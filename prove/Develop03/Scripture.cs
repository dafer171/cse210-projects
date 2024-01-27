public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();


    //public Scripture()
    //{

    //}

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }


    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            int randomIndex = random.Next(_words.Count);
            if (!_words[randomIndex].IsHidden())
            {
                _words[randomIndex].Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = $"{_reference.GetDisplayText()}: ";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }

        return displayText;
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}