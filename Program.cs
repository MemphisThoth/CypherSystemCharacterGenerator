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

            // Get the character type
            Console.WriteLine("Character Type:");
            Console.WriteLine("[1] Warrior");
            Console.WriteLine("[2] Adept");
            Console.WriteLine("[3] Explorer");
            Console.WriteLine("[4] Speaker");
            Console.Write("Choose a character type by number: ");
            string typeChoice = Console.ReadLine();

            // Convert the type choice to a more descriptive name.
            string characterType = "";
            switch (typeChoice)
            {
                case "1":
                    characterType = "Warrior";
                    break;
                case "2":
                    characterType = "Adept";
                    break;
                case "3":
                    characterType = "Explorer";
                    break;
                case "4":
                    characterType = "Speaker";
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Environment.Exit(1);
                    break;
            }


            // Write the stored values for texting.
            Console.WriteLine(playerName);
            Console.WriteLine(characterName);
            Console.WriteLine(characterType);
        }
    }
}