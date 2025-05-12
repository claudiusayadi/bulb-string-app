namespace StringApp;

public class SentenceBreaker
{
    public void Run()
    {
        Console.WriteLine("=== Sentence Breaker ===");
        Console.WriteLine("This utility breaks a sentence into individual words.");

        Console.Write("Enter a sentence: ");
        string? sentence = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(sentence))
        {
            Console.WriteLine("Error: Sentence cannot be empty.");
            return;
        }

        string[] words = BreakSentence(sentence);

        Console.WriteLine("\nWords in the sentence:");
        for (int i = 0; i < words.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {words[i]}");
        }
        Console.WriteLine($"\nTotal words: {words.Length}");
    }

    public string[] BreakSentence(string sentence)
    {
        string[] words = sentence.Split(" ");
        return words;
    }
}