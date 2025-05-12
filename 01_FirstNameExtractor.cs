using System;

namespace StringApp;

public class FirstNameExtractor
{
    public void Run()
    {
        Console.WriteLine("=== First Name Extractor ===");
        Console.WriteLine("This utility extracts the first name from a full name.");

        Console.Write("Enter a full name (first and last name): ");
        string? fullName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fullName))
        {
            Console.WriteLine("Error: Name cannot be empty.");
            return;
        }

        string firstName = GetFirstName(fullName);
        if (!string.IsNullOrEmpty(firstName))
        {
            Console.WriteLine($"First name: {firstName}");
        }
    }

    public string GetFirstName(string fullName)
    {
        bool hasSpace = fullName.Contains(' ');
        if (!hasSpace)
        {
            Console.WriteLine("Error: Please enter a valid full name with a first and last name separated by a space.");
            return string.Empty;
        }

        int index = fullName.IndexOf(' ');
        // string firstName = fullName[..index]; // editor suggested I used C# range - for future reference
        string firstName = fullName.Substring(0, index);
        return firstName;
    }
}