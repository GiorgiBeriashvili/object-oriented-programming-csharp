using System;

namespace Assignment_03.Utilities
{
    public static class UserInterface
    {
        public static void DisplayWeapons()
        {
            int index;

            PrintLine("\nChoose the weapon for the player:");

            for (index = 0; index < Program.Weapons.Count; index++)
            {
                PrintLine($"{index + 1} - {Program.Weapons[index].Name} (damage -> {Program.Weapons[index].Damage}, damage modifier range -> {Program.Weapons[index].DamageModifierRange.minimum}-{Program.Weapons[index].DamageModifierRange.maximum - 1})");
            }
        }

        public static void PromptRestart()
        {
            Print("\nWould you like to initiate the duel again? (Y/n): ");

            var restart = Console.ReadKey();

            if (restart.Key == ConsoleKey.N)
            {
                Program.Running = false;
            }
            else
            {
                PrintLine("\n");
            }
        }

        public static void Print(string value)
        {
            Console.Write(value);
        }

        public static void PrintLine(string value)
        {
            Console.WriteLine(value);
        }

        public static string ReadLine()
        {
            return Console.ReadLine();
        }
    }
}
