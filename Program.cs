using System;

namespace StringApp;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Welcome to StringApp ===");
        Console.WriteLine("A utility for working with strings and words");

        bool continueRunning = true;

        while (continueRunning)
        {
            DisplayMenu();

            Console.Write("\nEnter your choice (0-6): ");
            string? input = Console.ReadLine();

            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 6.");
                PressEnterToContinue();
                continue;
            }

            Console.WriteLine();

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Thank you for using StringApp. Goodbye!");
                    continueRunning = false;
                    break;

                case 1:
                    var firstNameExtractor = new FirstNameExtractor();
                    firstNameExtractor.Run();
                    break;

                case 2:
                    var nameChanger = new NameChanger();
                    nameChanger.Run();
                    break;

                case 3:
                    var sentenceBreaker = new SentenceBreaker();
                    sentenceBreaker.Run();
                    break;

                case 4:
                    WordCounter.Run();
                    break;

                case 5:
                    var wordChecker = new WordChecker();
                    wordChecker.Run();
                    break;

                case 6:
                    var wordReverser = new WordReverser();
                    wordReverser.Run();
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 0 and 6.");
                    break;
            }

            if (continueRunning)
            {
                PressEnterToContinue();
                Console.Clear();
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine("\n=== StringApp Menu ===");
        Console.WriteLine("1. First Name Extractor - Extract the first name from a full name");
        Console.WriteLine("2. Name Changer - Change parts of a full name");
        Console.WriteLine("3. Sentence Breaker - Break a sentence into words");
        Console.WriteLine("4. Word Counter - Count the number of words in a sentence");
        Console.WriteLine("5. Word Checker - Play a word guessing game");
        Console.WriteLine("6. Word Reverser - Reverse a word");
        Console.WriteLine("0. Exit");
    }

    static void PressEnterToContinue()
    {
        Console.WriteLine("\nPress Enter to continue...");
        Console.ReadLine();
    }
}