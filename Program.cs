using System;

namespace CypherSystemCharacterGenerator
{
    class Program
    {
        static void Main()
        {
            // Clear the console and write a title screen.
            Console.Clear();
            Console.WriteLine("Cypher System");
            Console.WriteLine("Character Generator");
            Console.WriteLine("by Jared Perkins\n");

            // Get the player's name.
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();

            // Get the character's name.
            Console.Write("Enter your character's name: ");
            string characterName = Console.ReadLine();


            // Write the stored values for texting.
            Console.WriteLine(playerName);
            Console.WriteLine(characterName);
        }
    }
}