namespace StringApp;

public class WordChecker
{
    public void Run()
    {
        Console.WriteLine("=== Word Checker Game ===");

        string secret = "When you pursue your Personal legend, the whole universe conspires to help you achieve it.";
        const int attempts = 5;
        int counter = attempts;
        int score = 0;

        Console.WriteLine("Welcome to Word Checker Guessing Game!");
        Console.WriteLine("I have a sentence. You are to guess a word. If the sentence contains that word, you win, if not, you lose.");
        Console.WriteLine($"You have {attempts} guesses in total!");
        Console.WriteLine("Enter '1' to exit the game any time.");

        while (counter > 0)
        {
            Console.WriteLine($"Guesses left: {counter} | Correct Guesses: {score}");
            Console.WriteLine("Enter your guess word");
            string? guess = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(guess))
            {
                Console.WriteLine("Error: Guess cannot be empty. Try again!");
                continue;
            }

            guess = guess.ToLower();

            if (guess == "1")
            {
                Console.WriteLine("Thanks for playing! Goodbye!!!");
                break;
            }
            else if (secret.Contains(guess, StringComparison.OrdinalIgnoreCase)) // string.Contains(string, StringComparison.OrdinalIgnoreCase)
            {
                score++;
                Console.WriteLine($"Hurray! '{guess}' is in the sentence.");
            }
            else
            {
                Console.WriteLine($"Ops...! '{guess}' is not in sentence. Try again!");
            }

            counter--;

            if (counter == 0)
            {
                Console.WriteLine("\n=== Game Over ===");
                Console.WriteLine($"You guessed {score} words correctly!");
                Console.WriteLine($"The sentence is {secret}.");
            }
        }
    }
}
