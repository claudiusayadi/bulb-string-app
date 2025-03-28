using System;

namespace StringApp;

public class FirstNameExtractor
{
    public string GetFirstName(string fullName)
    {
        bool hasSpace = fullName.Contains(" ");
        if (!hasSpace)
        {
            Console.WriteLine("Error: Please enter a valid full name with a first and last name separated by a space.");
        }

        int index = fullName.IndexOf(" ");
        string firstName = fullName.Substring(0, index);
        return firstName;
    }
}