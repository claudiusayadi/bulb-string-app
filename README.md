# StringApp

A console-based C# utility application for manipulating and working with strings and text.

## Overview

StringApp is a beginner-friendly C# console application that provides various string manipulation utilities. The application features a menu-driven interface that allows users to access different string processing tools, each designed to perform specific operations on text input.

## Features

The application includes the following utilities:

1. **First Name Extractor** - Extracts the first name from a full name input
2. **Name Changer** - Allows users to modify parts of a full name (first name, last name, or both)
3. **Sentence Breaker** - Splits a sentence into individual words and displays them
4. **Word Counter** - Counts the number of words in a given sentence
5. **Word Checker** - A word guessing game where users try to guess words in a hidden sentence
6. **Word Reverser** - Reverses the letters in a given word

## Technical Details

- **Language**: C# (.NET 9.0)
- **Project Type**: Console Application
- **Architecture**: Simple class-based design with separation of UI and business logic

## Getting Started

### Prerequisites

- .NET 9.0 SDK or later
- Any code editor (Visual Studio, Visual Studio Code, JetBrains Rider, etc.)

### Installation

1. Clone the repository:

   ```bash
   git clone https://github.com/claudiusayadi/bulb-string-app.git
   ```

2. Navigate to the project directory:

   ```bash
   cd bulb-string-app
   ```

3. Build the application:

   ```bash
   dotnet build
   ```

4. Run the application:

   ```bash
   dotnet run
   ```

## Usage

When you run the application, you'll be presented with a menu of options:

```text
=== StringApp Menu ===
1. First Name Extractor - Extract the first name from a full name
2. Name Changer - Change parts of a full name
3. Sentence Breaker - Break a sentence into words
4. Word Counter - Count the number of words in a sentence
5. Word Checker - Play a word guessing game
6. Word Reverser - Reverse a word
0. Exit
```

Enter the number corresponding to the utility you want to use and follow the prompts.

### Example Usage

#### First Name Extractor

```text
=== First Name Extractor ===
This utility extracts the first name from a full name.
Enter a full name (first and last name): John Doe
First name: John
```

#### Word Reverser

```text
=== Word Reverser ===
This utility reverses the letters in a word.
Enter a word to reverse: Hello
Reversed word: olleH
```

## Project Structure

The application is organized into separate classes for each utility:

- `Program.cs` - Contains the main menu and application flow
- `01_FirstNameExtractor.cs` - Extracts first names from full names
- `02_NameChanger.cs` - Allows modification of names
- `03_SentenceBreaker.cs` - Breaks sentences into words
- `04_WordCounter.cs` - Counts words in sentences
- `05_WordChecker.cs` - Implements the word guessing game
- `06_WordReverser.cs` - Reverses words

## Design Principles

This project follows these design principles:

1. **Separation of Concerns** - Each utility is encapsulated in its own class
2. **Simple Error Handling** - Uses Console.WriteLine() for error messages
3. **User-Friendly Interface** - Clear instructions and feedback for users
4. **Clean Code** - Readable and maintainable code structure

## Learning Objectives

This project is ideal for beginners learning C# and demonstrates:

- Basic string manipulation techniques
- Console input/output operations
- Class design and organization
- Simple error handling
- User interface design for console applications

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is open source and available under the [MIT License](LICENSE).
