using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Creativity: multiple scriptures
        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his only begotten Son"
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding"
            )
        };

        Random rand = new Random();
        Scripture scripture = scriptures[rand.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("\nPress ENTER to continue or type 'quit'");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3); // hide 3 words each round
        }
    }
}

// EXCEEDING REQUIREMENTS:
// 1. Program supports multiple scriptures stored in a list.
// 2. A random scripture is selected each time the program runs.
// 3. Clean object-oriented structure with encapsulation.
