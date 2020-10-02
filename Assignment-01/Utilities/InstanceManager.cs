using System;
using Assignment_01.Models;

namespace Assignment_01.Utilities
{
    public static class InstanceManager
    {
        public static User GetUser()
        {
            UserInterface.Print($"\nEnter the recipient user's index (1-{Program.Users.Count + 1}): ");

            var successfulParse = int.TryParse(UserInterface.ReadLine()?.Trim(), out var recipientIndex);

            if (!successfulParse) throw new InvalidCastException("Failed to parse string input to an integer.");

            if (recipientIndex <= 0 || recipientIndex > Program.Users.Count + 1) throw new IndexOutOfRangeException();

            if (recipientIndex == Program.Users.Count + 1)
            {
                return CreateUser();
            }

            UserInterface.PrintLine($"\nSuccessfully inferred user - `{Program.Users[recipientIndex - 1].FirstName} {Program.Users[recipientIndex - 1].LastName}`!\n");

            return Program.Users[recipientIndex - 1];
        }

        private static User CreateUser()
        {
            UserInterface.Print("\nEnter user's first name: ");
            var firstName = UserInterface.ReadLine();

            UserInterface.Print("Enter user's last name: ");
            var lastName = UserInterface.ReadLine();

            UserInterface.Print("Enter user's address: ");
            var address = UserInterface.ReadLine();

            UserInterface.PrintLine($"\nSuccessfully inferred user - `{firstName} {lastName}`!\n");

            var user = new User(firstName, lastName, address);

            Program.Users.Add(user);

            return user;
        }

        public static Message CreateMessage()
        {
            UserInterface.Print("Enter message's title: ");
            var title = UserInterface.ReadLine();
            UserInterface.Print("Enter message's content: ");
            var content = UserInterface.ReadLine();

            UserInterface.PrintLine($"\nSuccessfully inferred message titled as `{title}`!\n");

            var message = new Message(title, content);

            return message;
        }
    }
}