using System.Collections.Generic;
using Assignment_03.Models;
using Assignment_03.Models.Abstract;
using Assignment_03.Utilities;

namespace Assignment_03
{
    internal static class Program
    {
        internal static bool Running { get; set; }
        internal static List<Weapon> Weapons { get; private set; }

        public static void Main()
        {
            Initialize();

            while (Running)
            {
                Update();
            }
        }

        private static void Initialize()
        {
            Running = true;

            Weapons = new List<Weapon>
            {
                new Katana(name: "Katana", damage: 4, damageModifierRange: (minimum: 0, maximum: 5)),
                new DesertEagle(name: "Desert Eagle", damage: 3, damageModifierRange: (minimum: 1, maximum: 4))
            };
        }

        private static void Update()
        {
            var playerOne = InstanceManager.CreatePlayer();
            var playerTwo = InstanceManager.CreatePlayer();

            GameManager.Duel(playerOne, playerTwo);

            UserInterface.PromptRestart();
        }
    }
}
