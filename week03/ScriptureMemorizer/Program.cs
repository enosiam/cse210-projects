using System;

namespace ScriptureMemorizer
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a sample scripture
            Scripture scripture = new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."
            );

            // Alternative single-verse scripture:
            // Scripture scripture = new Scripture(
            //     new Reference("John", 3, 16),
            //     "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life."
            // );

            // Main loop
            while (true)
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                
                if (scripture.IsCompletelyHidden())
                {
                    Console.WriteLine("\nAll words are hidden. Press any key to exit.");
                    Console.ReadKey();
                    break;
                }

                Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    break;
                }

                scripture.HideRandomWords(3); // Hide 3 words at a time
            }
        }
    }
}