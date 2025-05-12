namespace StringApp;

public static class WordCounter
{
    public static void Run()
    {
        Console.WriteLine("=== Word Counter ===");
        Console.WriteLine("This utility counts the number of words in a sentence.");

        Console.Write("Enter a sentence: ");
        string? sentence = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(sentence))
        {
            Console.WriteLine("Error: Sentence cannot be empty.");
            return;
        }

        int count = CountWords(sentence);
        Console.WriteLine($"Word count: {count}");
    }

    public static int CountWords(string sentence)
    {
        string[] words = sentence.Split(' ');
        return words.Length;
    }
}