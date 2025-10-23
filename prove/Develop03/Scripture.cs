using System.Diagnostics;

public class Scripture
{
    List<Word> _words = new List<Word>();
    List<int> _wordsremaining = new List<int>();
    string _reference = "Matthew 5:14-16";
    string _verse = "14 Ye are the light of the world. A city that is set on an hill cannot be hid. 15 Neither do men light a candle, and put it under a bushel, but on a candlestick; and it giveth light unto all that are in the house. 16 Let your light so shine before men, that they may see your good works, and glorify your Father which is in heaven.";
    public Scripture()
    {
        string[] split = _verse.Split(' ');
        int counter = 0;
        for (int i = 0; i < split.Length; i++)
        {
            _wordsremaining.Add(counter);
            counter++;
            _words.Add(new Word(split[i]));
        }
    }

    public void DisplayScripture()
    {
        Console.WriteLine(_reference);
        foreach (Word word in _words)
        {
            Console.Write(word.ReturnWord() + " ");
        }
    }
    public void HideLines()
    {
        if (_wordsremaining.Count != 0)
        {
            for (int x = 0; x < 5; x++)
            {
                if (_wordsremaining.Count == 0)
                    break;
                Random random = new Random();
                int selection = random.Next(0, _wordsremaining.Count);
                _words[_wordsremaining[selection]].Hide();
                _wordsremaining.RemoveAt(selection);
            }
        }
        else
        {
            Console.WriteLine("Congrats You finishd the verse! Press enter to reset");
            // Reset
            for(int i = 0; i < _words.Count; i++)
            {
                _wordsremaining.Add(i);
                _words[i].UnHide();
            }
        }
    }
}