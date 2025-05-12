namespace StringApp;

public class NameChanger
{
    public void Run()
    {
        Console.WriteLine("=== Name Changer ===");
        Console.WriteLine("This utility allows you to change parts of a full name.");

        Console.Write("Enter a full name (first and last name): ");
        string? fullName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(fullName))
        {
            Console.WriteLine("Error: Name cannot be empty.");
            return;
        }

        string newName = ChangeName(fullName);
        Console.WriteLine($"Updated name: {newName}");

    }

    public string ChangeName(string name)
    {
        string[] fullName = [];
        if (name.Contains(' '))
        {
            fullName = name.Split(' ');
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid full name with a first and last name separated by a space.");
            return string.Empty;
        }

        Console.WriteLine("Please select the name you want to change: ");
        Console.WriteLine("1. First Name");
        Console.WriteLine("2. Last Name");
        Console.WriteLine("3. Both Names");

        string? input = Console.ReadLine();
        if (!int.TryParse(input, out int choice))
        {
            Console.WriteLine("Error: Please enter a valid number.");
            return string.Empty;
        }

        if (choice == 1)
        {
            Console.WriteLine("Enter new first name: ");
            string? newFirstName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newFirstName))
            {
                fullName[0] = newFirstName;
            }
            else
            {
                Console.WriteLine("Error: First name cannot be empty.");
                return string.Empty;
            }
        }
        else if (choice == 2)
        {
            Console.WriteLine("Enter new last name: ");
            string? newLastName = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(newLastName))
            {
                fullName[1] = newLastName;
            }
            else
            {
                Console.WriteLine("Error: Last name cannot be empty.");
                return string.Empty;
            }
        }
        else if (choice == 3)
        {
            Console.WriteLine("Enter new first name: ");
            string? newFirstName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newFirstName))
            {
                Console.WriteLine("Error: First name cannot be empty.");
                return string.Empty;
            }

            Console.WriteLine("Enter new last name: ");
            string? newLastName = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(newLastName))
            {
                Console.WriteLine("Error: Last name cannot be empty.");
                return string.Empty;
            }

            fullName[0] = newFirstName;
            fullName[1] = newLastName;
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid choice (1-3).");
            return string.Empty;
        }

        return string.Join(' ', fullName);
    }
}