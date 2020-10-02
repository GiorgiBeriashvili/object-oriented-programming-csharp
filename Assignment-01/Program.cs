using System.Collections.Generic;
using Assignment_01.Models;
using Assignment_01.Utilities;

namespace Assignment_01
{
    public static class Program
    {
        internal static bool Running { get; set; }
        internal static List<User> Users { get; private set; }

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

            Users = new List<User>
            {
                new User("Giorgi", "Beriashvili", "Tbilisi")
            };
        }

        private static void Update()
        {
            UserInterface.DisplayUsers();

            var user = InstanceManager.GetUser();
            var message = InstanceManager.CreateMessage();

            UserInterface.PrintLine($"Sending message to user #{user.Id}...\n");

            Post.SendMessageToUser(user, message);

            UserInterface.PromptRestart();
        }
    }
}
