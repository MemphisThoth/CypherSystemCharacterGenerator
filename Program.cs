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
            // Get the initial stats for each type.
            string characterType = "";
            int might = 0, speed = 0, intellect = 0;
            switch (typeChoice)
            {
                case "1":
                    characterType = "Warrior";
                    might = 10;
                    speed = 10;
                    intellect = 8;
                    break;
                case "2":
                    characterType = "Adept";
                    might = 7;
                    speed = 9;
                    intellect = 12;
                    break;
                case "3":
                    characterType = "Explorer";
                    might = 10;
                    speed = 9;
                    intellect = 9;
                    break;
                case "4":
                    characterType = "Speaker";
                    might = 8;
                    speed = 9;
                    intellect = 11;
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    Environment.Exit(1);
                    break;
            }

            // Have the user assign six points to stats
            Console.WriteLine("Distribute six additional points to stats:");
            Console.WriteLine("Current Stats:");
            Console.WriteLine("Might: {0} Speed: {1} Intellect: {2}", might, speed, intellect);
            Console.Write("Assign points to Might: ");
            int mightAssigned = int.Parse(Console.ReadLine());
            might = might + mightAssigned;
            Console.Write("Assign points to Speed: ");
            int speedAssigned = int.Parse(Console.ReadLine());
            speed = speed + speedAssigned;
            Console.Write("Assign points to Intellect: ");
            int intellectAssigned = int.Parse(Console.ReadLine());
            intellect = intellect + intellectAssigned;


            
       }
    }
}