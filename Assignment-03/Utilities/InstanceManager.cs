using System;
using Assignment_03.Models;
using Assignment_03.Models.Abstract;

namespace Assignment_03.Utilities
{
    public static class InstanceManager
    {
        public static Player CreatePlayer()
        {
            UserInterface.Print("Enter the player's name: ");
            var name = UserInterface.ReadLine();
            
            UserInterface.DisplayWeapons();
            var player = new Player(name, GetWeapon());

            UserInterface.PrintLine($"\nSuccessfully inferred player named as `{name}` armed with `{player.Weapon.Name}`!\n");

            return player;
        }

        private static Weapon GetWeapon()
        {
            UserInterface.Print($"\nEnter the player's weapon (1-{Program.Weapons.Count}): ");

            var successfulParse = int.TryParse(UserInterface.ReadLine()?.Trim(), out var weaponIndex);

            if (!successfulParse) throw new InvalidCastException("Failed to parse string input to an integer.");

            if (weaponIndex <= 0 || weaponIndex >= Program.Weapons.Count + 1) throw new IndexOutOfRangeException();

            return Program.Weapons[weaponIndex - 1];
        }
    }
}