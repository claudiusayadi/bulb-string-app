namespace StringApp;

public class WordReverser
{
    public void Run()
    {
        Console.WriteLine("=== Word Reverser ===");
        Console.WriteLine("This utility reverses the letters in a word.");

        Console.Write("Enter a word to reverse: ");
        string? word = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(word))
        {
            Console.WriteLine("Error: Word cannot be empty.");
            return;
        }

        string reversed = ReverseWord(word);
        Console.WriteLine($"Reversed word: {reversed}");
    }

    public string ReverseWord(string word)
    {
        char[] wordArray = word.ToCharArray();
        Array.Reverse(wordArray);
        string reversedWord = new(wordArray); // new string(array) => new(array)
        return reversedWord;
    }
}
